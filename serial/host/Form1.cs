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
        }

        void GetAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }



        void SendData()
        {
            try
            {
                if(!port.IsOpen)
                {
                    port.Open();
                    port.Write("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ReceiveData()
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendData();
        }
    }
}
