using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Data Conversion

            //string input = Console.ReadLine();
            //string input2 = Console.ReadLine();

            //int x = int.Parse(input);
            //int y = int.Parse(input2);

            //int x, y;
            //if (int.TryParse(input, out x))
            //{

            //    if (int.TryParse(input2, out y))
            //    {
            //        Console.WriteLine(x + y);
            //    }
            //    else
            //        Console.WriteLine("Invalid Second Input");
            //}
            //else
            //    Console.WriteLine("Invalid First Input");

            #endregion

            //Console.Write("Enter your age : ");
            //int age = int.Parse(Console.ReadLine());

            //if (age > 60)
            //{
            //    Console.WriteLine("Non taxable");
            //}
            ////else if(age < 18)
            ////{
            ////    Console.WriteLine("You are still not considered");
            ////}
            //else 
            //    Console.WriteLine("Taxable");

            ////condition ? true : false
            //string isTaxable = age > 60 || age < 18 ? "Non Taxable" : "Taxable";
            //Console.WriteLine(isTaxable);

            Console.Write("Enter the weekday");
            string weekday = Console.ReadLine();

            switch(weekday)
            {
                case "Monday": Console.WriteLine("Starting the week");break;
                case "Tuesday": Console.WriteLine("Work at wrap speed"); break;
                case "Wednesday": Console.WriteLine("Half though the week"); break;
                case "Thursday": Console.WriteLine("Time to wrap the week"); break;
                case "Friday": Console.WriteLine("Thank god its friday"); break;
                case "Saturday": 
                case "Sunday": Console.WriteLine("Hello Weekend"); break;
                default: Console.WriteLine("Not a vaid weekday");break;
            }
        }
      
    }
}
