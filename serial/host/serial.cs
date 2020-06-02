using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace host
{
    class Serial
    {
        public SerialPort port;

        /*Serial(SerialPort Port)
        {
            port = Port;
        }*/

        public void SendData(string data)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                    port.Write(data);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
