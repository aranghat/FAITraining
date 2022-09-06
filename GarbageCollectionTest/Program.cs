using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            for(int i=0;i<10000000;i++)
            {
                Employee employee = new Employee();
                employee.Id = i;
                employee.Name = i.ToString();

                Console.WriteLine(i);
                employees.Add(employee);

                GC.Collect();
            }
        }
    }
}
