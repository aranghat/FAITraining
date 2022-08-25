using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int tokenId = 1;
            string userChoice = "Y";
            Queue<Token> issuedTokens = new Queue<Token>();

            do
            {
                Token token = new Token();
                Console.Write("Name : ");
                token.CustomerName = Console.ReadLine();

                Console.Write("Mobile : ");
                token.Mobile = Console.ReadLine();

                Console.Write("Any notes ? : ");
                token.Note = Console.ReadLine() ;
                token.TokenId = new Random().Next(99,999);

                issuedTokens.Enqueue(token);

                Console.Write("Do you want to continue ( Y/ N) : ");
                userChoice = Console.ReadLine();
            }
            while (userChoice == "Y");


            Console.WriteLine("Waiting for Operator---------------------------------------");
            Console.ReadLine();

            foreach(var token in issuedTokens)
            {
                Console.WriteLine(token);
                Console.ReadLine();
            }
        }
    }
}
