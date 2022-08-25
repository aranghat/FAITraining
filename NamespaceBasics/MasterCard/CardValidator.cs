using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visa.Cards.Validator
{
    public class CardValidator
    {
        public bool Validate(string cardNumber)
        {
            Console.WriteLine("Master Card Validator");
            return cardNumber.StartsWith("42") && cardNumber.Length == 16;
        }
    }
}
