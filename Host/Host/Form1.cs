using System;
using System.IO.Ports;
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
        //SerialPort port = new SerialPort("COM3", 9600);
        string path;

        bool isConnected = false;
        String[] ports;
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
            GetAvailableComPorts();

         
        }
        void GetAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();

            foreach (string port in ports) // miss niet hier neer zetten
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
                if (!port.IsOpen)
                {
                    port.Open();
                    json.SendTextFile(port, path);
                    Console.WriteLine(port.ReadLine());
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
            finally
            {
                port.Close();
            }
        }

        private void btnMakeJson_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string filePath = folderBrowser.SelectedPath;
                filePath += "\\" + tBFileName.Text + ".json";
                try
                {
                    json.MakeJson(filePath);
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(json.ReadJson(port).Name);
        //}
    }
}
