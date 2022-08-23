using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingandUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x;
            // //var y;
            //// string message = "Hello World";
            // var message = "Hello World"; //Implicitly typed variable
            // var myage = 34;

            // var builder = new StringBuilder();

            //object x = 10; //Boxing
            //// x = "Hello World";

            //int y = 10;
            //int sum = (int)x + y; //Unboxing
            Console.Write("Enter your grade/marks");
            string userInput = Console.ReadLine();

            dynamic marks;
            if (float.TryParse(userInput, out float per))
            {
                marks = per;
                Console.WriteLine(marks.GetType());
            }
            else
            {
                marks = userInput;
                Console.WriteLine(marks.GetType());
            }


            if (marks is float)
            {
                
                var basePercengae = marks as float?;
                Console.WriteLine("Its float");
            }
            else
                Console.WriteLine("It in grades");

        }
    }
}
