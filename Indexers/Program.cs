using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            WeekDays weekDays = new WeekDays();
            var firstDay = weekDays[0];

            weekDays[0] = "MONDAY";

            Console.WriteLine(firstDay);
        }
    }
}
