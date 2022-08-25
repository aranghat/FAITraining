using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var loanAccount1 = new LoanAccount { CustomerName = "Sree", MobileNumber = "12345", Id = 10001 };
            var loanAccount2 = new LoanAccount { CustomerName = "Sree", MobileNumber = "12345", Id = 10001 };

            if (loanAccount1 == loanAccount2)
            {
                Console.WriteLine("Both acounts are same");
            }
            else
                Console.WriteLine("Both are diff accounts");*/

            var account1 = new SavingsAccount
            {
                CustomerName = "Sree" ,
                MobileNumber = "12345",
                Id = 10001,
                Amount = 50000,
                Type = AccountTypes.Savings
            };

            var account2 = new SavingsAccount
            {
                CustomerName = "Sree",
                MobileNumber = "12345",
                Id = 10003,
                Amount = 150000,
                Type= AccountTypes.Savings

            };

            var consolidatedAccount = account1 
                + account2;
            Console.WriteLine($"Net balance is {consolidatedAccount.Amount}");
        }
    }
}
