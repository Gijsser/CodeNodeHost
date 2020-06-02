using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace host
{
    public partial class Form1 : Form
    {
        Serial serial = new Serial();
        bool isConnected = false;
        String[] ports;
        SerialPort port;

        public Form1()
        {
            InitializeComponent();

            GetAvailableComPorts();

            foreach (string port in ports)
            {
                coboCommunication.Items.Add(port);
                if (ports[0] != null)
                {
                    coboCommunication.SelectedItem = ports[0];
                }
            }

            //serial.port = SerialPort.;
        }

        void GetAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                serial.SendData("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void coboCommunication_SelectedIndexChanged(object sender, EventArgs e)
        {
            serial.port = port;
        }
    }
}
