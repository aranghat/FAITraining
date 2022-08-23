using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? initDeposit = 5000;
            InitBankAccount(initDeposit);
        }

        static void InitBankAccount(int? initialDeposit)
        {
            if(initialDeposit.HasValue)
            {
                Console.WriteLine($"Account opened with {initialDeposit}");
            }
            else
            {
                Console.Write("Provide initiaial amount : ");
                var deposit = int.Parse(Console.ReadLine());

                Console.WriteLine($"Account opened with {deposit}");
            }
        }
    }
}
