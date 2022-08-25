using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBasics
{
    public class ValidateFavNumber
    {
        public bool Validate(int favNumber)
        {
            if (favNumber >= 0 && favNumber <= 100)
                return true;
            else
                throw new 
                    InvalidFavNumberException
                    ("Invalid Fav Number : Number must be between 0-100");
        }
    }
}
