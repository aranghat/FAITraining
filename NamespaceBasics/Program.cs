using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = Visa.Cards.Validator;
using M = MasterCard.Cards.Validator;

namespace NamespaceBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            V.CardValidator cardValidator 
                = new V.CardValidator();
            M.CardValidator masterCardValidator = new M.CardValidator();
        }
    }
}
