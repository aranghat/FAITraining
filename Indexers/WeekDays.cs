using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class WeekDays
    {
        string[] weekdayList = { "Monday"
                                , "Tuesday"
                            , "Wednesday"
                            , "Thursday"
                            , "Friday"
                            , "Saturday"
                , "Sunday" };

        public string this[int index]
        {
            get
            {
                return weekdayList[index];
            }
            set
            {
                weekdayList[index] = value;
            }
        }
    }
}
