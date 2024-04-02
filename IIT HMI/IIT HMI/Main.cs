using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Configuration;

namespace IIT_HMI
{
    // Windows form that lets user login with username and hashed password from database
    // Created by Kim Langvannskås
    // Latest update 01.04.2024
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtPasswordNew.UseSystemPasswordChar = true;
            txtPasswordNewRepeat.UseSystemPasswordChar = true;

            // Allow for enter press after password typing for easy login
            txtPassword.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    SignIn();
                    e.Handled = true;
                }
            };
        }

        static string ConvertToSHA256(string input)
        {
            // Method to convert a string into a SHA256 hash for enctryption
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        static (bool, string) CheckLoginCredentials(string username, string password)
        {
            // Method for checking if the username and the hashed password exists in the database
            int resultCode = 0;
            string resultMessage = "";
            bool result = false;
            string connectionString = ConfigurationManager.ConnectionStrings["IIT"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("CheckLogin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 64).Value = password;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            resultCode = reader.GetInt32(0);
                            resultMessage = reader.GetString(1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot connect to database");
                    }
                }
            }

            if (resultCode == 1)
            {
                result = true;
            }
            return (result, resultMessage);
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Checkbox for showing/hiding password as it is being typed

            if (chbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void SignIn()
        {
            // Sign user in with username and password from database and open ViewPage Form

            string username, password, firstname;
            bool resultCode;

            username = txtUsername.Text;
            password = ConvertToSHA256(txtPassword.Text);
            (resultCode, firstname) = CheckLoginCredentials(username, password);
            if (resultCode)
            {
                ViewPage frmViewPage = new ViewPage(firstname, username);
                frmViewPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Signin button
            SignIn();
        }

        private void liLblNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show panel for adding new user

            panLogin.Visible = false;
            panSignup.Visible = true;
        }

        private void chbShowPasswordNew_CheckedChanged(object sender, EventArgs e)
        {
            // Checkbox for showing/hiding password as it is being typed at signup panel

            if (chbShowPasswordNew.Checked == true)
            {
                txtPasswordNew.UseSystemPasswordChar = false;
                txtPasswordNewRepeat.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordNew.UseSystemPasswordChar = true;
                txtPasswordNewRepeat.UseSystemPasswordChar = true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Button for running stored procedure with the database to add new user
            //Comming later
        }
    }
}
