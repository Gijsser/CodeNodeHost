using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    public class Json
    {
        public List<DataJson> Data { get; set; }
        public Json()
        {
            Data = new List<DataJson>();
        }

        public DataJson ReadJson(ISerialPort port)
        {
            return JsonConvert.DeserializeObject<DataJson>(port.ReadLine());   //File.ReadAllText(@"D:\HBO\Semester 4\PTT\jsontekst2.json")

            //// deserialize JSON directly from a file
            //using (StreamReader file = File.OpenText(@"D:\HBO\Semester 4\PTT\jsontekst.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    return (Sent)serializer.Deserialize(file, typeof(Sent));
            //}
        }

        public void MakeJson(string path, DataJson data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Data cant be null");
            }

            Data.Add(data);

            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, data);
            }
        }
        public void SendTextFile(SerialPort port, string FileName)
        {
            port.Write(File.OpenText(FileName).ReadToEnd());
        }
    }
}
