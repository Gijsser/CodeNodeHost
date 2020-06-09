using System.IO.Ports;

namespace Host
{
    public class SerialPortAdapter : ISerialPort
    {
        private readonly SerialPort _serialPort;

        public SerialPortAdapter(SerialPort serialPort)
        {
            _serialPort = serialPort;
        }

        public string ReadLine()
        {
            return _serialPort.ReadLine();
        }

        public void Open()
        {
            _serialPort.Open();
        }

        public void Close()
        {
            _serialPort.Close();
        }
    }
}
