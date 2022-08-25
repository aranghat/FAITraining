using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratableClass
{
    public class Continents 
        : IEnumerable<string>
    {
        public IEnumerator<string> 
            GetEnumerator()
        {
            yield return "Asia";
            yield return "Africa";
            yield return "South America";
            yield return "North America";
            yield return "Australia";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
