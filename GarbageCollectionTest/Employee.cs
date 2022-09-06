using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionTest
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get => photo; set => photo = value; }

        byte[] photo = new byte[1028];

    }
}
