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
        //SerialPort port = new SerialPort("COM3", 9600);
        string path;

        //bool isConnected = false;
        string[] ports;
        //SerialPort port;
        public Form1()
        {
            InitializeComponent();
            GetAvailableComPorts();

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
            if (serial.GetPort().IsOpen
                && serial.GetPort().BytesToRead > 0)
            {
                Console.WriteLine(json.ReadJson(serial.GetPort()).sensNr);
                Console.WriteLine(json.ReadJson(serial.GetPort()).instNr);
                Console.WriteLine(json.ReadJson(serial.GetPort()).BRet);
                Console.WriteLine(json.ReadJson(serial.GetPort()).Data);
            }
        }

        private void ReadTimer_Tick(object sender, EventArgs e)
        {
            ReadJson();
            Console.WriteLine("test");
        }

        private void btnMakeJson_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (Int32.TryParse(tbID.Text, out id))
            {
                Data data = new Data(tbName.Text, tbAdres.Text, id);
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
