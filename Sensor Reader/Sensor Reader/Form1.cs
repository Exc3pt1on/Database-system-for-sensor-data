using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sensor_Reader
{
    // Application for collecting sensor data from DAQmx and inserting into database
    // Created by Kim Langvannskås
    // Last updated 02.04.2024
    public partial class Form1 : Form
    {
        public bool read = false;
        private List<double> SensorValue = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private double ReadSensor(string sensor, string channel)
        {
            // Method for reading the DAQmx sensor

            double value;
            string sensorName;
            sensorName = sensor + "/" + channel;
            NationalInstruments.DAQmx.Task analogInTask = new NationalInstruments.DAQmx.Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel("dev2/ai0", "myAIChannel", AITerminalConfiguration.Rse, 0, 5, AIVoltageUnits.Volts);
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);

            value = reader.ReadSingleSample();
            return value;
        }
        private void WriteToDatabase(string name, double value)
        {
            // Method for wrinting the sensor data to the database
            // A connection string is created in the 'App.config' file for easy implementation of database connectionstring

            string connectionString = ConfigurationManager.ConnectionStrings["IIT"].ConnectionString;
            DateTime dateTime = DateTime.Now;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("InsertSensorValue", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@SensorName", SqlDbType.NChar).Value = name;
                        command.Parameters.Add("@SensorValue", SqlDbType.Float).Value = value;
                        command.Parameters.Add("@DateTime", SqlDbType.DateTime).Value = dateTime;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private double ConvertPT100FromVoltageToTemperature(double voltage)
        {
            // Convert PT100 temperature sensor voltage to temperature (from 1-5V to 0-50C)
            return (voltage - 1) * 50 / 4;
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            // Enable / disable timer for sampling

            if (read)
            {
                tmr1.Stop();
                read = false;
                btnRead.Text = "Read";
            }
            else
            {
                tmr1.Start();
                read = true;
                btnRead.Text = "Stop reading";
            }
        }
        private double MovingAverage(List<double> data, int windowSize = 10)
        {
            // Method for filtering the analog signals
            // This method is a copy from Software engineering assignment 1
            double result;

            int start = Math.Max(0, data.Count - windowSize);
            int end = data.Count;

            // Calculate the average of the values in the window
            double sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += data[i];
            }
            result = sum / (end - start);

            return Math.Round(result, 2);
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            // Timer that reads sensor data every timestep and uploads it to database

            double value, filteredValue;
            string sensor, channel, name;

            // Get sensor attributes
            name = txtName.Text;
            sensor = txtSensor.Text;
            channel = txtChannel.Text;

            // Read sensor, convert and filter
            value = ReadSensor(sensor, channel);
            value = Math.Round(ConvertPT100FromVoltageToTemperature(value), 2);
            SensorValue.Add(value);
            filteredValue = MovingAverage(SensorValue);

            // Display sensor values
            txtRaw.Text = value.ToString();
            txtValue.Text = filteredValue.ToString();

            // Insert into database sensor values
            WriteToDatabase(name, filteredValue);
        }
    }
}
