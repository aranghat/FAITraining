using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // string mesage = "Hello There,\n\nWhat a\twonderful";
            //string filename = "c:\\training\\program.cs";
            // string quote = "He said \"He will be on time\"";

            // string filename = @"c:\training\program.cs";
            // string quote2 = $@"This is going to be a long
            //      Sentance with multiple paragraphs
            //     and lines with {quote}";

            // Console.WriteLine(filename);
            //// Console.WriteLine(quote);
            // Console.WriteLine(quote2);

            //string email1 = "sreehari@gmail.com";
            //string email2 = "SREEHARI@GMAIL.com";

            ////if (email1 == email2)
            //if(email1.Equals(email2,StringComparison.OrdinalIgnoreCase))
            //    Console.WriteLine("Both are same strings");
            //else
            //    Console.WriteLine("Both are diffrent");



            //Console.WriteLine(message.ToUpper());
            //Console.WriteLine(message.ToLower());

            //string message = "What a wonderful, world; and, a wonderful day";

            //char[] spltArray = { ',', ';' };
            //string[] arr = message.Split(spltArray); //message.Split(',');
            //foreach (string a in arr)
            //    Console.WriteLine(a.Trim());

            //if (message.ToLower().Contains("world"))
            //    Console.WriteLine("The message has world");
            //else
            //    Console.WriteLine("The string doe snot contain world");

            //int locWorld = message.LastIndexOf("wonderful");
            ////message.IndexOf("wonderful");
            ////Console.WriteLine($"Location is {locWorld}");

            //string replace = message.Replace("wonderful", "beautiful");
            //Console.WriteLine(message);
            //Console.WriteLine(replace);

            //string message = "What a wonderful, world; and, a wonderful day";
            //string subStr = message.Substring(7);
            //string subStr2 = message.Substring(7,5);
            //string subStr3 = message.Substring(message.Length - 5);

            //Console.WriteLine(subStr);
            //Console.WriteLine(subStr2);

            //string removed = message.Remove(7, 6);
            //Console.WriteLine(removed);
            //Console.WriteLine(removed.Insert(7, "Beauti"));

            //string userInput = Console.ReadLine();
            //char[] possibleSplits = { ' ', ',', ';', '.' };
            //Console.WriteLine($"Total Words : {userInput.Split(possibleSplits).Length}");

            //string message = "This is part of the sentance";
            //message += " and the rest of the message";

            //Console.WriteLine(message);

            //StringBuilder builder = new StringBuilder();

            //builder.AppendLine("Hello");
            //builder.AppendLine(" World out there");
            //builder.AppendLine(" What is the day are we on");

            //Console.WriteLine(builder.ToString());

            //string userInput = "";
            //StringBuilder builder = new StringBuilder();
            //do
            //{
            //    userInput = Console.ReadLine();
            //    
            //        builder.Append(userInput);

            //} while (userInput != "exit");

            //Console.WriteLine(builder.ToString());

            StringBuilder builder2 = new StringBuilder();
            do
            {
                builder2.Append(Console.ReadLine());

            } while (!builder2.ToString().Contains("exit"));

            Console.WriteLine(builder2.ToString().Replace("exit",""));

        }
    }
}
