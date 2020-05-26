using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace json_file
{
    public partial class Form1 : Form
    {
        Json json = new Json();
        SerialPort port = new SerialPort("COM3", 9600);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(json.ReadJson().Name);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            json.MakeJson();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                try
                {
                    port.Open();
                    json.SendTextFile(port, path);
                    Console.WriteLine(port.ReadLine());
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
            
        }
    }
}
