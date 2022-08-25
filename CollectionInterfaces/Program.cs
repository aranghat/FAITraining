using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Student> students = new List<Student>();
            SortedSet<Student> students = new SortedSet<Student>();

            var student1 = new Student { Name = "Sree", StudentId = 1001 };
            var student2 = new Student { Name = "Sree", StudentId = 1003 };
            var student3 = new Student { Name = "Bill", StudentId = 1002 };

            students.Add(student1);
            students.Add(student2);

            if (students.Contains(student3))
                Console.WriteLine("Student already exist");
            else
                students.Add(student3);

            foreach (var student in students)
                Console.WriteLine($"Id : {student.StudentId},Name : {student.Name}");

        }
    }
}
