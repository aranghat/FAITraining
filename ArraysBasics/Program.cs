using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] favNumbers = new int[10];

            //string[] cities = { "Bengaluru", "Chennei", "Mumbai" };

            //Console.WriteLine(cities.Length);
            //foreach (var citi in cities)
            //    Console.WriteLine(citi);

            //cities[2] = "Trivandrum";
            //Console.WriteLine(cities[2]);




            //for(var i=0;i< 10;i++)
            //{
            //    var userInput = Console.ReadLine();
            //    if (!int.TryParse(userInput, out favNumbers[i]))
            //        break;

            //}
            //favNumbers[0] = 10;
            //favNumbers[1] = 20;
            //favNumbers[2] = 30;

            //for (var i = 0; i < 10; i++)
            //    Console.WriteLine(favNumbers[i]);

            //foreach (var num in favNumbers)
            //    Console.WriteLine(num);


            //int?[] arr = new int?[10];
            //arr[0] = 10;
            //arr[1] = 20;
            //arr[3] = 30;

            //foreach (var a in arr)
            //    Console.WriteLine(a);

            string[,] cityCapitals =  {
                { "Karnataka", "Bengaluru"},
                { "Kerala", "Trivandrum" },
                { "Tamilnadu", "Chennei" }
            };

            /*new string[3, 2];*/

            //cityCapitals[0, 0] = "Karnataka";
            //cityCapitals[0, 1] = "Bengaluru";

            //cityCapitals[1, 0] = "Kerala";
            //cityCapitals[1, 1] = "Trivandrum";

            //cityCapitals[2, 0] = "Tamilnadu";
            //cityCapitals[2, 1] = "Chennei";

            //for (var row = 0; row < 3; row++)
            //{
            //    Console.WriteLine($"State:{cityCapitals[row, 0]}, Capital : {cityCapitals[row, 1]}");

            //    //for (var col = 0; col < 2; col++)
            //    //    Console.Write($"{cityCapitals[row, col]} ");

            //    //Console.WriteLine();
            //}

            //string[][] studentMarks = new string[3][];

            //studentMarks[0] = new string[] {"Sree", "45", "65", "75" };
            //studentMarks[1] = new string[] {"Student 2", "45" };
            //studentMarks[2] = new string[] { "Studnet 3", "45", "65" };

            //for(var row=0;row<3;row++)
            //{
            //    foreach (var s in studentMarks[row])
            //        Console.Write(s + " ");

            //    Console.WriteLine();
            //}


            object[,] studentMarks = new object[3, 2];
            var totalMarks = 0;
            var currentMaxMarks = 0;
            var currentMaxMarksRow = 0;

            for(var row=0;row<3;row++)
            {
                Console.Write("Enter Subject : ");
                studentMarks[row, 0] = Console.ReadLine();

                Console.Write("Enter Marks : ");
                studentMarks[row, 1] = int.Parse(Console.ReadLine());

                totalMarks += (int)studentMarks[row, 1];

                if((int)studentMarks[row, 1] > currentMaxMarks)
                {
                    currentMaxMarks = (int)studentMarks[row, 1];
                    currentMaxMarksRow = row;
                }
            }

            Console.WriteLine($"Max Marks is {currentMaxMarks} " +
                $"and the subject is {studentMarks[currentMaxMarksRow, 0]}");
        }
    }
}
