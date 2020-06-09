using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Host
{
   public class Serial
    {
        SerialPort port;

        public SerialPort GetPort()
        {
            return port;
        }

        public void SetPort(string Port)
        {
            port = new SerialPort(Port, 9600);
        }

        public string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }
    }
}
