namespace Sensor_Reader
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtSensor = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSensor = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lvlRaw = new System.Windows.Forms.Label();
            this.txtRaw = new System.Windows.Forms.TextBox();
            this.lblDegC1 = new System.Windows.Forms.Label();
            this.lblDegC2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(141, 84);
            this.txtChannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(116, 22);
            this.txtChannel.TabIndex = 0;
            this.txtChannel.Text = "ai0";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(113, 255);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(127, 33);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtSensor
            // 
            this.txtSensor.Location = new System.Drawing.Point(141, 54);
            this.txtSensor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSensor.Name = "txtSensor";
            this.txtSensor.Size = new System.Drawing.Size(116, 22);
            this.txtSensor.TabIndex = 2;
            this.txtSensor.Tag = "";
            this.txtSensor.Text = "dev2";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 116);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 22);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Sensor1";
            // 
            // lblSensor
            // 
            this.lblSensor.AutoSize = true;
            this.lblSensor.Location = new System.Drawing.Point(79, 57);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(50, 16);
            this.lblSensor.TabIndex = 4;
            this.lblSensor.Text = "Sensor";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(79, 87);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(56, 16);
            this.lblChannel.TabIndex = 5;
            this.lblChannel.Text = "Channel";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(79, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(141, 206);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(116, 22);
            this.txtValue.TabIndex = 7;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(43, 209);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(88, 16);
            this.lblValue.TabIndex = 8;
            this.lblValue.Text = "Filtered value";
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lvlRaw
            // 
            this.lvlRaw.AutoSize = true;
            this.lvlRaw.Location = new System.Drawing.Point(59, 180);
            this.lvlRaw.Name = "lvlRaw";
            this.lvlRaw.Size = new System.Drawing.Size(70, 16);
            this.lvlRaw.TabIndex = 10;
            this.lvlRaw.Text = "Raw value";
            // 
            // txtRaw
            // 
            this.txtRaw.Location = new System.Drawing.Point(141, 176);
            this.txtRaw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRaw.Name = "txtRaw";
            this.txtRaw.ReadOnly = true;
            this.txtRaw.Size = new System.Drawing.Size(116, 22);
            this.txtRaw.TabIndex = 9;
            // 
            // lblDegC1
            // 
            this.lblDegC1.AutoSize = true;
            this.lblDegC1.Location = new System.Drawing.Point(265, 180);
            this.lblDegC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDegC1.Name = "lblDegC1";
            this.lblDegC1.Size = new System.Drawing.Size(43, 16);
            this.lblDegC1.TabIndex = 11;
            this.lblDegC1.Text = "deg C";
            // 
            // lblDegC2
            // 
            this.lblDegC2.AutoSize = true;
            this.lblDegC2.Location = new System.Drawing.Point(265, 209);
            this.lblDegC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDegC2.Name = "lblDegC2";
            this.lblDegC2.Size = new System.Drawing.Size(43, 16);
            this.lblDegC2.TabIndex = 12;
            this.lblDegC2.Text = "deg C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 313);
            this.Controls.Add(this.lblDegC2);
            this.Controls.Add(this.lblDegC1);
            this.Controls.Add(this.lvlRaw);
            this.Controls.Add(this.txtRaw);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.lblSensor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSensor);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtChannel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sensor reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtSensor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSensor;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label lvlRaw;
        private System.Windows.Forms.TextBox txtRaw;
        private System.Windows.Forms.Label lblDegC1;
        private System.Windows.Forms.Label lblDegC2;
    }
}

