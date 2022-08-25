using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAccount
{
    public enum AccountTypes
    {
        Savings,
        Current,
        Loan,
        CreditCardAccount
    }
    public abstract class Account
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public float Amount { get;  set; }  

        public AccountTypes Type { get; set; }

        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine(
                $@"Customer Name : {CustomerName}
                   MobileNumber : {MobileNumber}
                   Amount : {Amount}");
        }

        public virtual void DisplayAccountInfo(bool showCustomerContact)
        {
            this.MobileNumber = "*******";
            DisplayAccountInfo();
        }
        public abstract void Deposit(float amount);

        public void ShowTotalAccountAmount()
        {
            Console.WriteLine($"Total Amount : {Amount}");
        }

        public static bool operator==(Account acc1,Account acc2)
        {
            return acc1.Id == acc2.Id;
        }

        public static bool operator!=(Account acc1, Account acc2)
        {
            return acc1.Id != acc2.Id;
        }

      

    }

    public class SavingsAccount : Account
    {
        public float MinBalance { get { return 5000; } }
        public void WithDraw(float withDrawAmount)
        {
            if (withDrawAmount <= Amount)
            {
                //Amount -= withDrawAmount;
            }
            else
                throw new Exception("Insufficient Balance");
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("ACCOUNT TYPE : SAVINGS ACCOUNT");
            base.DisplayAccountInfo();
            Console.WriteLine($"Min Balance : {MinBalance}");
        }

        public override void Deposit(float amount)
        {
            Amount += amount;
        }

        //Hiding the base class implimentation
        public new void ShowTotalAccountAmount()
        {
            Console.WriteLine($"Account Balance : {Amount}");
        }

        public static SavingsAccount operator+(SavingsAccount acc1
            ,SavingsAccount acc2)
        {
            SavingsAccount conAcc = new SavingsAccount();
            conAcc.CustomerName = acc1.CustomerName;
            conAcc.Amount = acc1.Amount + acc2.Amount;

            return conAcc;
        }
    }

    public sealed class PremiumSavingsAccount : SavingsAccount
    {

    }

    

    public class LoanAccount : Account
    {
        public float IntrestRate { get; set; }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("ACCOUNT TYPE : LOAN ACCOUNT");
            base.DisplayAccountInfo();
            Console.WriteLine($"Intrest Rate : {IntrestRate}");
        }

        public override void Deposit(float amount)
        {
            Amount -= amount;
        }
    }
}
