using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms.DataVisualization.Charting;

namespace IIT_HMI
{
    // Windows form that shows sensor data from database
    // Created by Kim Langvannskås
    // Latest update 01.04.2024
    public partial class ViewPage : Form
    {
        private string firstName;
        private string username;
        public ViewPage(string Firstname, string Username)
        {
            InitializeComponent();
            username = Username;
            firstName = Firstname.TrimEnd();
            lblName.Text = firstName;
            // Fill the first combobox with buildings attached to user
            FillComboBox("Username", username, "Address", "View_Building", cboBuilding);
        }
        private void FillComboBox(string input, string inputValue, string output, string view, System.Windows.Forms.ComboBox combobox)
        {
            // Method for filling a combobox with values attaced to parent
            //input & inputValue belongs to parent, output belongs to child, view is the name of the SQL view, combobox is the object to fill

            combobox.Items.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["IIT"].ConnectionString;
            SqlDataAdapter sda;
            DataTable dt;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM " + view + " WHERE " + input + " = '" + inputValue + "';";

                    sda = new SqlDataAdapter(sqlQuery, connection);
                    dt = new DataTable();
                    sda.Fill(dt);
                    string[] dataArray = dt.AsEnumerable().Select(row => row.Field<string>(output).TrimEnd()).ToArray();
                    combobox.Items.AddRange(dataArray);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private DataTable GetSensorValueFromDatabase()
        {
            // Get sensor data based on comboboxes & fill display objects with data

            double min, max, mean, sd;
            string type, address, room, sensor;

            address = cboBuilding.Text;
            room = cboRoom.Text;
            sensor = cboSensors.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["IIT"].ConnectionString;
            SqlDataAdapter sda;
            DataTable dt;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dt = new DataTable();
                try
                {
                    connection.Open();
                    string sqlQuery = "SELECT Value, Time FROM View_SensorReading " +
                        "WHERE Username = '" + username + "' AND Address = '" + address + "' " +
                        "AND Room = '" + room + "' AND Name = '" + sensor + "';"; 

                    sda = new SqlDataAdapter(sqlQuery, connection);
                    sda.Fill(dt);
                    dgvSensors.DataSource = dt;
                    
                    dgvSensors.CellFormatting += (sender, e) =>
                    {
                        if (e.ColumnIndex >= 0 && dgvSensors.Columns[e.ColumnIndex].Name == "Time" && e.Value != null && e.Value is DateTime)
                        {
                            DateTime dateTimeValue = (DateTime)e.Value;
                            e.Value = dateTimeValue.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                    };
                    dgvSensors.Columns["Time"].FillWeight = 70;
                    dgvSensors.Columns["Value"].FillWeight = 30;

                    sqlQuery = $"SELECT Min, Max, Mean, Sd, Type FROM View_SensorData " +
                        "WHERE Username = '" + username + "' AND Address = '" + address + "' " +
                        "AND Room = '" + room + "' AND Name = '" + sensor + "';";
                    sda = new SqlDataAdapter( sqlQuery, connection);
                    DataTable dt2 = new DataTable();
                    sda.Fill(dt2);
                    min = Convert.ToDouble(dt2.Rows[0]["Min"]);
                    max = Convert.ToDouble(dt2.Rows[0]["Max"]);
                    mean = Convert.ToDouble(dt2.Rows[0]["Mean"]);
                    sd = Convert.ToDouble(dt2.Rows[0]["Sd"]);
                    type = Convert.ToString(dt2.Rows[0]["Type"]);

                    txtMin.Text = min.ToString();
                    txtMax.Text = max.ToString();
                    txtMean.Text = mean.ToString();
                    txtSd.Text = sd.ToString();
                    txtType.Text = type.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                return dt;
            }
        }

        private void InsertIntoChart(DataTable dt, int N)
        {
            // Method for inserting sensor values into chart
            // dt is DataTable with values, N is number of values to show (0 gives all values)
            try
            {
                chartSensors.Titles.Clear();
                chartSensors.Series.Clear();
                Series series = new Series();
                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.DateTime;
                IEnumerable<DataRow> clippedList;

                if (N != 0)
                {
                    clippedList = dt.AsEnumerable().Skip(Math.Max(0, dt.Rows.Count - N));
                }
                else
                {
                    clippedList = dt.AsEnumerable();
                }
                

                foreach (DataRow row in clippedList)
                {
                    DateTime time = Convert.ToDateTime(row["Time"]);
                    double temp = Convert.ToDouble(row["Value"]);
                    series.Points.AddXY(time, temp);
                }

                chartSensors.Titles.Add("Sensor readings");
                chartSensors.ChartAreas[0].AxisX.Title = "Time";
                chartSensors.ChartAreas[0].AxisY.Title = "Temperature °C";
                chartSensors.Series.Add(series);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSensor_Click(object sender, EventArgs e)
        {
            // Button for collecting data when correct sensor is chosen

            DataTable dt = GetSensorValueFromDatabase();
            InsertIntoChart(dt, 0);
        }

        private void cboBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Automatically update checkbox with rooms attached to building

            string building;
            building = cboBuilding.Text;
            FillComboBox("Address", building, "Room", "View_Room", cboRoom);
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Automatically update checkbox with sensors attached to room

            string room;
            room = cboRoom.Text;
            FillComboBox("Room", room, "Name", "View_Sensor", cboSensors);
        }

        private void btnChartAll_Click(object sender, EventArgs e)
        {
            DataTable dt = GetSensorValueFromDatabase();
            InsertIntoChart(dt, 0);
        }

        private void btnChartLast_Click(object sender, EventArgs e)
        {
            DataTable dt = GetSensorValueFromDatabase();
            InsertIntoChart(dt, 10);
        }
    }
    
}
