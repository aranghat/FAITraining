using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenTask
{
    public class Token
    {
        public int TokenId { get; set; }
        public string CustomerName { get; set; }
        public string Mobile { get; set; }
        public string Note { get; set; }

        public override string ToString()
        {
            return $"TOKENID : {TokenId}, Name : {CustomerName}, Note : {Note}";
        }
    }
}
