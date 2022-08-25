using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBasics
{
    public class InvalidFavNumberException : Exception
    {
        public InvalidFavNumberException()
        {
            base.HelpLink = "http://google.com";
        }

        public InvalidFavNumberException(string message) 
            : base(message)
        {
            base.HelpLink = "http://google.com";
        }

        public InvalidFavNumberException(string message
            , Exception innerException) : base(message, innerException)
        {
        }

      
    }
}
