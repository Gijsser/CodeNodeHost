using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    public class DataJson
    {
        public int SensNr { get; set; }
        public int InstNr { get; set; }
        public int BRet { get; set; }
        public int Data { get; set; }
        public List<DataJson> Json { get => Json; set => Json = value; }

        public DataJson(int sensNr, int instNr, int bRet, int data)
        {
            SensNr = sensNr;
            InstNr = instNr;
            BRet = bRet;
            Data = data;
        }
        public void Add(DataJson data)
        {
            if (data != null)
            {
                Json.Add(data);
            }
            else
            {
                throw new ArgumentNullException("Data cant be null");
            }
            //data.Add(new Data()
            //{
            //    name = "test",
            //    adres = "A3G66",
            //    id = 2
            //});
        }

    }
}
