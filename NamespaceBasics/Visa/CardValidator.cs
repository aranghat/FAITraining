using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCard.Cards.Validator
{
    public class CardValidator
    {
        public bool Validate(string cardNumber)
        {
            Console.WriteLine("Visa Card Validator");
            return cardNumber.StartsWith("65") && cardNumber.Length == 16;
        }
    }
}
