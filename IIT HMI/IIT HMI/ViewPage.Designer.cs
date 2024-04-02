namespace IIT_HMI
{
    partial class ViewPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSensor = new System.Windows.Forms.Button();
            this.dgvSensors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSensors = new System.Windows.Forms.ComboBox();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.cboBuilding = new System.Windows.Forms.ComboBox();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblSensor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblMean = new System.Windows.Forms.Label();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.lblSd = new System.Windows.Forms.Label();
            this.txtSd = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblSensorValue = new System.Windows.Forms.Label();
            this.chartSensors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChartAll = new System.Windows.Forms.Button();
            this.btnChartLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSensor
            // 
            this.btnSensor.Location = new System.Drawing.Point(181, 178);
            this.btnSensor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSensor.Name = "btnSensor";
            this.btnSensor.Size = new System.Drawing.Size(96, 33);
            this.btnSensor.TabIndex = 1;
            this.btnSensor.Text = "Collect data";
            this.btnSensor.UseVisualStyleBackColor = true;
            this.btnSensor.Click += new System.EventHandler(this.btnSensor_Click);
            // 
            // dgvSensors
            // 
            this.dgvSensors.AllowUserToAddRows = false;
            this.dgvSensors.AllowUserToDeleteRows = false;
            this.dgvSensors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensors.Location = new System.Drawing.Point(351, 85);
            this.dgvSensors.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSensors.Name = "dgvSensors";
            this.dgvSensors.ReadOnly = true;
            this.dgvSensors.RowHeadersVisible = false;
            this.dgvSensors.RowHeadersWidth = 51;
            this.dgvSensors.Size = new System.Drawing.Size(292, 432);
            this.dgvSensors.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome";
            // 
            // cboSensors
            // 
            this.cboSensors.FormattingEnabled = true;
            this.cboSensors.Location = new System.Drawing.Point(169, 149);
            this.cboSensors.Name = "cboSensors";
            this.cboSensors.Size = new System.Drawing.Size(121, 24);
            this.cboSensors.TabIndex = 4;
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(169, 117);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(121, 24);
            this.cboRoom.TabIndex = 5;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // cboBuilding
            // 
            this.cboBuilding.FormattingEnabled = true;
            this.cboBuilding.Location = new System.Drawing.Point(169, 85);
            this.cboBuilding.Name = "cboBuilding";
            this.cboBuilding.Size = new System.Drawing.Size(121, 24);
            this.cboBuilding.TabIndex = 6;
            this.cboBuilding.SelectedIndexChanged += new System.EventHandler(this.cboBuilding_SelectedIndexChanged);
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Location = new System.Drawing.Point(108, 88);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(55, 16);
            this.lblBuilding.TabIndex = 7;
            this.lblBuilding.Text = "Building";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(119, 120);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(44, 16);
            this.lblRoom.TabIndex = 8;
            this.lblRoom.Text = "Room";
            // 
            // lblSensor
            // 
            this.lblSensor.AutoSize = true;
            this.lblSensor.Location = new System.Drawing.Point(113, 152);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(50, 16);
            this.lblSensor.TabIndex = 9;
            this.lblSensor.Text = "Sensor";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(560, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 16);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Firstname";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(169, 259);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(121, 22);
            this.txtMin.TabIndex = 11;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(132, 262);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(31, 16);
            this.lblMin.TabIndex = 12;
            this.lblMin.Text = "Min:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(128, 290);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(35, 16);
            this.lblMax.TabIndex = 14;
            this.lblMax.Text = "Max:";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(169, 287);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(121, 22);
            this.txtMax.TabIndex = 13;
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(119, 318);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(44, 16);
            this.lblMean.TabIndex = 16;
            this.lblMean.Text = "Mean:";
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(169, 315);
            this.txtMean.Name = "txtMean";
            this.txtMean.ReadOnly = true;
            this.txtMean.Size = new System.Drawing.Size(121, 22);
            this.txtMean.TabIndex = 15;
            // 
            // lblSd
            // 
            this.lblSd.AutoSize = true;
            this.lblSd.Location = new System.Drawing.Point(40, 346);
            this.lblSd.Name = "lblSd";
            this.lblSd.Size = new System.Drawing.Size(123, 16);
            this.lblSd.TabIndex = 18;
            this.lblSd.Text = "Standard deviation:";
            // 
            // txtSd
            // 
            this.txtSd.Location = new System.Drawing.Point(169, 343);
            this.txtSd.Name = "txtSd";
            this.txtSd.ReadOnly = true;
            this.txtSd.Size = new System.Drawing.Size(121, 22);
            this.txtSd.TabIndex = 17;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(81, 234);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(82, 16);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Sensor type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(169, 231);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(121, 22);
            this.txtType.TabIndex = 19;
            // 
            // lblSensorValue
            // 
            this.lblSensorValue.AutoSize = true;
            this.lblSensorValue.Location = new System.Drawing.Point(442, 65);
            this.lblSensorValue.Name = "lblSensorValue";
            this.lblSensorValue.Size = new System.Drawing.Size(102, 16);
            this.lblSensorValue.TabIndex = 21;
            this.lblSensorValue.Text = "Latest readings:";
            // 
            // chartSensors
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSensors.ChartAreas.Add(chartArea1);
            this.chartSensors.Location = new System.Drawing.Point(687, 85);
            this.chartSensors.Name = "chartSensors";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartSensors.Series.Add(series1);
            this.chartSensors.Size = new System.Drawing.Size(460, 364);
            this.chartSensors.TabIndex = 22;
            this.chartSensors.Text = "chart1";
            // 
            // btnChartAll
            // 
            this.btnChartAll.Location = new System.Drawing.Point(783, 463);
            this.btnChartAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChartAll.Name = "btnChartAll";
            this.btnChartAll.Size = new System.Drawing.Size(125, 33);
            this.btnChartAll.TabIndex = 23;
            this.btnChartAll.Text = "All samples";
            this.btnChartAll.UseVisualStyleBackColor = true;
            this.btnChartAll.Click += new System.EventHandler(this.btnChartAll_Click);
            // 
            // btnChartLast
            // 
            this.btnChartLast.Location = new System.Drawing.Point(928, 463);
            this.btnChartLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChartLast.Name = "btnChartLast";
            this.btnChartLast.Size = new System.Drawing.Size(125, 33);
            this.btnChartLast.TabIndex = 24;
            this.btnChartLast.Text = "Last 10 samples";
            this.btnChartLast.UseVisualStyleBackColor = true;
            this.btnChartLast.Click += new System.EventHandler(this.btnChartLast_Click);
            // 
            // ViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 554);
            this.Controls.Add(this.btnChartLast);
            this.Controls.Add(this.btnChartAll);
            this.Controls.Add(this.chartSensors);
            this.Controls.Add(this.lblSensorValue);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblSd);
            this.Controls.Add(this.txtSd);
            this.Controls.Add(this.lblMean);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSensor);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblBuilding);
            this.Controls.Add(this.cboBuilding);
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.cboSensors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSensors);
            this.Controls.Add(this.btnSensor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewPage";
            this.Text = "Sensor data";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSensor;
        private System.Windows.Forms.DataGridView dgvSensors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSensors;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.ComboBox cboBuilding;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblSensor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.Label lblSd;
        private System.Windows.Forms.TextBox txtSd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblSensorValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensors;
        private System.Windows.Forms.Button btnChartAll;
        private System.Windows.Forms.Button btnChartLast;
    }
}

