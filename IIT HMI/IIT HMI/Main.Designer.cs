﻿namespace IIT_HMI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chbShowPassword = new System.Windows.Forms.CheckBox();
            this.lblNewAccount = new System.Windows.Forms.Label();
            this.liLblNewAccount = new System.Windows.Forms.LinkLabel();
            this.panLogin = new System.Windows.Forms.Panel();
            this.panSignup = new System.Windows.Forms.Panel();
            this.txtPasswordNewRepeat = new System.Windows.Forms.TextBox();
            this.lblPasswordNewRepeat = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblPasswordNew = new System.Windows.Forms.Label();
            this.txtUsernameNew = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.chbShowPasswordNew = new System.Windows.Forms.CheckBox();
            this.lblUsernameNew = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.panLogin.SuspendLayout();
            this.panSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(42, 178);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(123, 27);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(41, 66);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(124, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(41, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(124, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(38, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(38, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // chbShowPassword
            // 
            this.chbShowPassword.AutoSize = true;
            this.chbShowPassword.Location = new System.Drawing.Point(41, 141);
            this.chbShowPassword.Name = "chbShowPassword";
            this.chbShowPassword.Size = new System.Drawing.Size(124, 20);
            this.chbShowPassword.TabIndex = 5;
            this.chbShowPassword.Text = "Show password";
            this.chbShowPassword.UseVisualStyleBackColor = true;
            this.chbShowPassword.CheckedChanged += new System.EventHandler(this.chbShowPassword_CheckedChanged);
            // 
            // lblNewAccount
            // 
            this.lblNewAccount.AutoSize = true;
            this.lblNewAccount.Location = new System.Drawing.Point(19, 233);
            this.lblNewAccount.Name = "lblNewAccount";
            this.lblNewAccount.Size = new System.Drawing.Size(146, 16);
            this.lblNewAccount.TabIndex = 7;
            this.lblNewAccount.Text = "Don\'t have an account?";
            // 
            // liLblNewAccount
            // 
            this.liLblNewAccount.AutoSize = true;
            this.liLblNewAccount.Location = new System.Drawing.Point(44, 261);
            this.liLblNewAccount.Name = "liLblNewAccount";
            this.liLblNewAccount.Size = new System.Drawing.Size(97, 16);
            this.liLblNewAccount.TabIndex = 8;
            this.liLblNewAccount.TabStop = true;
            this.liLblNewAccount.Text = "Create account";
            this.liLblNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liLblNewAccount_LinkClicked);
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.txtUsername);
            this.panLogin.Controls.Add(this.liLblNewAccount);
            this.panLogin.Controls.Add(this.btnSignIn);
            this.panLogin.Controls.Add(this.lblNewAccount);
            this.panLogin.Controls.Add(this.txtPassword);
            this.panLogin.Controls.Add(this.chbShowPassword);
            this.panLogin.Controls.Add(this.lblUsername);
            this.panLogin.Controls.Add(this.lblPassword);
            this.panLogin.Location = new System.Drawing.Point(95, 22);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(209, 416);
            this.panLogin.TabIndex = 9;
            // 
            // panSignup
            // 
            this.panSignup.Controls.Add(this.txtPasswordNewRepeat);
            this.panSignup.Controls.Add(this.lblPasswordNewRepeat);
            this.panSignup.Controls.Add(this.txtLastname);
            this.panSignup.Controls.Add(this.txtPasswordNew);
            this.panSignup.Controls.Add(this.lblLastname);
            this.panSignup.Controls.Add(this.lblPasswordNew);
            this.panSignup.Controls.Add(this.txtUsernameNew);
            this.panSignup.Controls.Add(this.btnSignUp);
            this.panSignup.Controls.Add(this.txtFirstname);
            this.panSignup.Controls.Add(this.chbShowPasswordNew);
            this.panSignup.Controls.Add(this.lblUsernameNew);
            this.panSignup.Controls.Add(this.lblFirstname);
            this.panSignup.Location = new System.Drawing.Point(95, 22);
            this.panSignup.Name = "panSignup";
            this.panSignup.Size = new System.Drawing.Size(226, 416);
            this.panSignup.TabIndex = 10;
            this.panSignup.Visible = false;
            // 
            // txtPasswordNewRepeat
            // 
            this.txtPasswordNewRepeat.Location = new System.Drawing.Point(43, 280);
            this.txtPasswordNewRepeat.Name = "txtPasswordNewRepeat";
            this.txtPasswordNewRepeat.Size = new System.Drawing.Size(123, 22);
            this.txtPasswordNewRepeat.TabIndex = 10;
            // 
            // lblPasswordNewRepeat
            // 
            this.lblPasswordNewRepeat.AutoSize = true;
            this.lblPasswordNewRepeat.Location = new System.Drawing.Point(40, 261);
            this.lblPasswordNewRepeat.Name = "lblPasswordNewRepeat";
            this.lblPasswordNewRepeat.Size = new System.Drawing.Size(114, 16);
            this.lblPasswordNewRepeat.TabIndex = 11;
            this.lblPasswordNewRepeat.Text = "Repeat password";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(42, 148);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(123, 22);
            this.txtLastname.TabIndex = 6;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Location = new System.Drawing.Point(43, 233);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.Size = new System.Drawing.Size(123, 22);
            this.txtPasswordNew.TabIndex = 7;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(39, 129);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(69, 16);
            this.lblLastname.TabIndex = 8;
            this.lblLastname.Text = "Last name";
            // 
            // lblPasswordNew
            // 
            this.lblPasswordNew.AutoSize = true;
            this.lblPasswordNew.Location = new System.Drawing.Point(40, 214);
            this.lblPasswordNew.Name = "lblPasswordNew";
            this.lblPasswordNew.Size = new System.Drawing.Size(67, 16);
            this.lblPasswordNew.TabIndex = 9;
            this.lblPasswordNew.Text = "Password";
            // 
            // txtUsernameNew
            // 
            this.txtUsernameNew.Location = new System.Drawing.Point(42, 47);
            this.txtUsernameNew.Name = "txtUsernameNew";
            this.txtUsernameNew.Size = new System.Drawing.Size(123, 22);
            this.txtUsernameNew.TabIndex = 1;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(42, 348);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(122, 27);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(42, 94);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(123, 22);
            this.txtFirstname.TabIndex = 2;
            // 
            // chbShowPasswordNew
            // 
            this.chbShowPasswordNew.AutoSize = true;
            this.chbShowPasswordNew.Location = new System.Drawing.Point(30, 308);
            this.chbShowPasswordNew.Name = "chbShowPasswordNew";
            this.chbShowPasswordNew.Size = new System.Drawing.Size(131, 20);
            this.chbShowPasswordNew.TabIndex = 5;
            this.chbShowPasswordNew.Text = "Show passwords";
            this.chbShowPasswordNew.UseVisualStyleBackColor = true;
            this.chbShowPasswordNew.CheckedChanged += new System.EventHandler(this.chbShowPasswordNew_CheckedChanged);
            // 
            // lblUsernameNew
            // 
            this.lblUsernameNew.AutoSize = true;
            this.lblUsernameNew.Location = new System.Drawing.Point(39, 28);
            this.lblUsernameNew.Name = "lblUsernameNew";
            this.lblUsernameNew.Size = new System.Drawing.Size(70, 16);
            this.lblUsernameNew.TabIndex = 3;
            this.lblUsernameNew.Text = "Username";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(39, 75);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(69, 16);
            this.lblFirstname.TabIndex = 4;
            this.lblFirstname.Text = "First name";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.panSignup);
            this.Name = "Main";
            this.Text = "Sign in";
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panSignup.ResumeLayout(false);
            this.panSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chbShowPassword;
        private System.Windows.Forms.Label lblNewAccount;
        private System.Windows.Forms.LinkLabel liLblNewAccount;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Panel panSignup;
        private System.Windows.Forms.TextBox txtUsernameNew;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.CheckBox chbShowPasswordNew;
        private System.Windows.Forms.Label lblUsernameNew;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblPasswordNew;
        private System.Windows.Forms.TextBox txtPasswordNewRepeat;
        private System.Windows.Forms.Label lblPasswordNewRepeat;
    }
}