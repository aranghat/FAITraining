using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Varaible Params
            //Console.WriteLine(Add(10, 20));
            //Console.WriteLine(Add(10, 20,30));
            //Console.WriteLine(Add(10, 20,40,50));
            //Console.WriteLine(Add(10));
            #endregion

            //int x;
            ////Console.WriteLine($"STEP 1 : Before Method : {x}");
            ////ChangeDataByRef(ref x);
            //ChangeDataByOut(out x);
            //Console.WriteLine($"STEP 2 : After Methods : {x}");

            (int salary, string name, int id) empdetails = (1000, "Sreehari Aranghat", 50);

            Console.WriteLine(empdetails.id);
            Console.WriteLine(empdetails.name);
        }

        static void ChangeData(int a)
        {
            Console.WriteLine($"Before Change In Method : {a}");
            a = a * new Random().Next(99, 999);
            Console.WriteLine($"After Change In Method : {a}");
        }

        static void ChangeDataByRef(ref int a)
        {
            Console.WriteLine($"Before Change In Method : {a}");
            a = a * new Random().Next(99, 999);
            Console.WriteLine($"After Change In Method : {a}");
        }

        static void ChangeDataByOut(out int a)
        {
            a = 100;
            Console.WriteLine($"Before Change In Method : {a}");
            a = a * new Random().Next(99, 999);
            Console.WriteLine($"After Change In Method : {a}");
        }

        //static int Add(params object[] values)
        //{
        //    int sum = 0;
        //    foreach (object o in values)
        //        sum += (int)o;

        //    return sum;
        //}

    }
}
