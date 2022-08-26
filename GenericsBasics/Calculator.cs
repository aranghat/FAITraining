using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsBasics
{
    public class Calculator
    {
        public int Add(int x,int y)
        {
            return x + y;
        }

        public float Add(float x, float y)
        {
            return x + y;
        }
    }

    public class CalculatorGeneric 
    {
        public T Add<T>(T x, T y) 
        {
            return 0;
            //return x + y;
        }
    }
}
