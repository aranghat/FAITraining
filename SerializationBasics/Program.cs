using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace SerializationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 10001, Name = "Sre", Email = "sree@gmail.com" });
            employees.Add(new Employee { Id = 10002, Name = "Bill", Email = "bill@gmail.com" });
            employees.Add(new Employee { Id = 10003, Name = "Emma", Email = "emma@gmail.com" });



            //XmlSerializer xml = new XmlSerializer(typeof(List<Employee>));
            //Stream stream = new FileStream(@"D:\FATraining\Temp\Serialize\Employees.xml"
            //                        , FileMode.OpenOrCreate);

            ////xml.Serialize(stream, employees);

            //employees =  (List<Employee>)xml.Deserialize(stream);

            //foreach(var e in employees)
            // Console.WriteLine(e);

            //var binaryFormatter = new BinaryFormatter();
            //Stream stream =  new FileStream(@"D:\FATraining\Temp\Serialize\Employees.bin"
            //                       , FileMode.OpenOrCreate);

            ////binaryFormatter.Serialize(stream, employees);

            //employees =  (List<Employee>)binaryFormatter.Deserialize(stream);

            //foreach (var e in employees)
            //    Console.WriteLine(e);

            //var jsonContent =  JsonConvert.SerializeObject(employees);
            //File.AppendAllText(@"D:\FATraining\Temp\Serialize\Employees.json", jsonContent);

            var jsonContent = File.ReadAllText(@"D:\FATraining\Temp\Serialize\Employees.json");
            employees = JsonConvert.DeserializeObject<List<Employee>>(jsonContent);

            foreach (var e in employees)
                Console.WriteLine(e);
        }
    }
}
