using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(@"D:\FATraining\Temp\Log.txt"));
            Trace.Listeners.Add(new EventLogTraceListener("MyApp"));
            Trace.AutoFlush = true;
            //Trace.Listners.Add(new SmsTraceListner());


            try
            {
                Console.Write("Enter the max number : ");
                Debug.WriteLine($"[{DateTime.Now}] : Awaiting User Input");
                int maxCounter = int.Parse(Console.ReadLine());
                Debug.WriteLine($"[{DateTime.Now}] : User Input -> {maxCounter}");

                for (int i = 0; i < maxCounter; i++)
                {
                    var x = new Random().Next(0, 999);
                    var y = new Random().Next(999, 9999);

                    var sum = Add(x, y);
                    Console.WriteLine($"{x} + {y} = {sum}");
                }
            }
            catch(Exception excp)
            {
                Debug.WriteLine(excp.ToString());
                Trace.WriteLine(excp.ToString());
            }

        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
