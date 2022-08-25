using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInterfaces
{
    public class Student : IEquatable<Student>
                          ,IComparable<Student>
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int CompareTo(Student other)
        {
            return Name.CompareTo(other.Name);
            /*
            if (StudentId > other.StudentId)
                return 1;
            else if (StudentId < other.StudentId)
                return -1;
            else
                return 0;*/
        }

        public bool Equals(Student other)
        {
            return this.StudentId == other.StudentId;
        }
    }
}
