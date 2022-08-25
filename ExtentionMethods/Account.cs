using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    public class Account
    {
        public int AcccountId { get; set; }
        public int Balance { get; set; }
        public int OverDraftAmount { get; set; }

        public void DisplayBalance()
        {
            Console.WriteLine($"AccountId : {AcccountId}" +
                $" Balance :  {Balance}");
        }
    }
}
