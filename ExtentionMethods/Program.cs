using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.AcccountId = 1011;
            account.Balance = 10000;
            account.OverDraftAmount = 2000;

            account.DisplayBalance();
            account.DisplayNewAccountBalance();

            string message = "Hello World";
            Console.WriteLine(message.CountWords());
        }

       
    }
}
