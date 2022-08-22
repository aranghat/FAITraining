using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int counter = 0;

            //while(counter < 10)
            //{
            //    Console.WriteLine($"Count = {counter}");
            //    counter++;
            //}

            //int pinnumber = 0;
            //do
            //{
            //    Console.WriteLine("Enter your pin : ");
            //    pinnumber = int.Parse(Console.ReadLine());
            //}
            //while (pinnumber != 1234);

            for (int counter = 0; counter < 10; counter++)
                Console.WriteLine($"Counter : {counter}");

            int c = 0;
            for (; c < 10; c++)
                Console.WriteLine($"Counter : {c}");

            string [] cities = { "Bengaluru", "Chennei", "Trivandrum" };
            //for (int i = 0; i < cities.Length; i++)
            //    Console.WriteLine(cities[i]);
            foreach (string city in cities)
                Console.Write(city + " ");
        }
    }
}
