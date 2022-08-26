using GenericsBasics.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GenericsBasics
{
    public class SaveData
    {
       public List<T> Get<T>()
       {
            string name = typeof(T).Name;

            //Deserialize
            Stream strem = new FileStream($@"D:\FATraining\Temp\Serialize\{name}.xml"
               , FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(List<T>));

            List<T> list = (List<T>)xml.Deserialize(strem);

            return list;
       }

        public void Save<T>(List<T> list) where T : class
        {
            //Serialize and sabe the file
            string name = typeof(T).Name;
            Stream strem = new FileStream($@"D:\FATraining\Temp\Serialize\{name}.xml"
                ,FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(List<T>));

            xml.Serialize(strem, list);
        }
    }
}
