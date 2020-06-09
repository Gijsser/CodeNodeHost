public interface ISerialPort
{
    string ReadLine();
    void Open();
    void Close();
}