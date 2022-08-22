using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numbers
            byte b = 0;
            Console.WriteLine(byte.MinValue + ":" + byte.MaxValue); //8 Bit
            Console.WriteLine(sbyte.MinValue + ":" + sbyte.MaxValue);

            Console.WriteLine(short.MinValue + ":" + short.MaxValue); //16 Bit
            Console.WriteLine(ushort.MinValue + ":" + ushort.MaxValue);

            Console.WriteLine(int.MinValue + ":" + int.MaxValue); //32 Bit
            Console.WriteLine(uint.MinValue + ":" + uint.MaxValue);

            Console.WriteLine(long.MinValue + ":" + long.MaxValue); //64 Bit
            Console.WriteLine(ulong.MinValue + ":" + ulong.MaxValue);

            //Decimal Numbers
            float f = 0.01234567890123456789F;
            Console.WriteLine(f);
            double d = 0.01234567890123456789;
            Console.WriteLine(d);
            decimal de = 0.012345678901234567890123456789M;
            Console.WriteLine(de);

            //String and Char
            string message = "What a wonderful way";
            Console.WriteLine(message);
            char a = 'A';

            //Boolen
            bool bo = true;
            bool isActive = true;
            bool isAvailable = false;
        }
    }
}
