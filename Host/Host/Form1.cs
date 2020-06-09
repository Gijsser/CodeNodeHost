using System;
//using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Host
{
    public partial class Form1 : Form
    {
        Json json = new Json();
        Serial serial = new Serial();
        ISerialPort serialPort;
        //SerialPort port = new SerialPort("COM3", 9600);
        string path;

        //bool isConnected = false;
        string[] ports;
        //SerialPort port;
        public Form1()
        {

            InitializeComponent();
            GetAvailableComPorts();
            serial.SetPort(serial.GetPorts()[0]);
            serialPort = new SerialPortAdapter(serial.GetPort());

        }
        void GetAvailableComPorts()
        {
            ports = serial.GetPorts();

            foreach (string port in ports)
            {
                cBComPoort.Items.Add(port);
                if (ports[0] != null)
                {
                    cBComPoort.SelectedItem = ports[0];
                }
            }
        }

        private void btnSelectJson_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;

            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serial.GetPort().IsOpen)
                {
                    serial.GetPort().Open();
                    json.SendTextFile(serial.GetPort(), path);
                    Console.WriteLine(serial.GetPort().ReadLine());
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                serial.GetPort().Close();
            }
        }
        public void ReadJson()
        {
            try
            {
                serialPort.Open();
                if (serial.GetPort().IsOpen )
                {
                    var result = json.ReadJson(serialPort);
                    Console.WriteLine(result.SensNr);
                    Console.WriteLine(result.InstNr);
                    Console.WriteLine(result.BRet);
                    Console.WriteLine(result.Data);
                }
            }
            finally
            {
                serialPort.Close();
            }

        }

        private void ReadTimer_Tick(object sender, EventArgs e)
        {
            ReadJson();
            Console.WriteLine("test1");
        }

        private void btnMakeJson_Click(object sender, EventArgs e)
        {

            DataJson data = new DataJson((int)nUDSenNr.Value, (int)nUDInstNr.Value, (int)nUDBRet.Value, new List<int> { (int)nUDData.Value }.ToArray());
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string filePath = folderBrowser.SelectedPath;
                filePath += "\\" + tBFileName.Text + ".json";
                try
                {
                    json.MakeJson(filePath, data);
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void cBComPoort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serial.SetPort(cBComPoort.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(json.ReadJson(port).Name);
        //}
    }
}
