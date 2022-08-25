using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    public static class AccontExtentionMethods
    {
        public static void
            DisplayNewAccountBalance(
            this Account account)
        {
            Console.WriteLine($"Account Id : {account.AcccountId}" +
                $",Balance : {account.Balance - account.OverDraftAmount}");
        }
    }

    public static class StringExtentions
    {
        public static int CountWords(this string str)
        {
            return str.Split(' ').Count();
        }
    }
}
