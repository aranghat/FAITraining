using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSales bangloreUnit = new CarSales();
            CarSales kochiUnit = new CarSales();
            CarSales mumbaiUnit = new CarSales();

            bangloreUnit.SalesCompleted();
            bangloreUnit.SalesCompleted();
            bangloreUnit.SalesCompleted();
            bangloreUnit.SalesCompleted();

            kochiUnit.SalesCompleted();
            kochiUnit.SalesCompleted();

            mumbaiUnit.SalesCompleted();

            Console.WriteLine($"Total Sales : {bangloreUnit.Sales}");
            Console.WriteLine($"Total Sales : {kochiUnit.Sales}");
            Console.WriteLine($"Total Sales : {mumbaiUnit.Sales}");

            Console.WriteLine($"Net Global Sales : " +
                $"{GlobalSales.TotalSales}");
        }
    }
}
