using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string City { get; set; }
        public int CTC { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}\tAge:{Age}\tGender:{Gender}\tCity:{City}\tCTC:{CTC}";
        }
    }
}
