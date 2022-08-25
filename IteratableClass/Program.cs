using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Continents continents 
                = new Continents();
         

            foreach (var c in continents)
                Console.WriteLine(c);
        }
    }
}
