using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    public class Data
    {
        public string Name { get; set; }
        public string Adres { get; set; }
        public int ID { get; set; }
        public List<Data> Json { get => Json; set => Json = value; }

        public Data(string name, string adres, int id)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name is NULL");
            }
            if (adres == null)
            {
                throw new ArgumentNullException("adres is NULL");
            }
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Id can not be lower then 0");
            }
            Name = name;
            Adres = adres;
            ID = id;
        }
        public void Add(Data data)
        {
            if (data != null)
            {
                Json.Add(data);
            }
            else
            {
                throw new ArgumentNullException("Drink cant be null");
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
