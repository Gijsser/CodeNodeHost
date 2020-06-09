using System.IO.Ports;

namespace Host
{
    public class SerialPortAdapter : ISerialPort
    {
        private readonly SerialPort _serialPort;

        public SerialPortAdapter(SerialPort serialPort)
        {
            _serialPort = serialPort;
            _serialPort.ReadTimeout = 10;//my serial port is connected to nothing and I get tired of waiting for failure.
        }

        virtual public string ReadLine()
        {
            _serialPort.Open();
            string result;
            try
            {
                result = _serialPort.ReadLine();
            }
            finally
            {
                _serialPort.Close();
            }
            return result;
        }
    }
}
