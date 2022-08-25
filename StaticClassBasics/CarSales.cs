using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassBasics
{
    public static class GlobalSales
    {
        public static int TotalSales
        { get; private set; }
        public static void RegisterSale()
        {
            TotalSales++;
        }
    }
    public class CarSales
    {
        public int Sales { get; private set; }
        
        public void SalesCompleted()
        {
            Sales++;
            GlobalSales.RegisterSale();
        }

    }
}
