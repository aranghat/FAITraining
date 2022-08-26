using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student { Gender = "MALE", Name = "Sree" };

            Func<Student, Student> modifyFun = UpdateSalutation;
            modifyFun += ConvertToUpper;

            student = modifyFun(student);

            Action<Student> print = delegate (Student s)
            {
                Console.WriteLine($"{s.Name} {s.Gender}");
            };

            print(student);

        }

        static Student UpdateSalutation(Student student)
        {
            if (student.Gender == "MALE")
                student.Name = "Mr." + student.Name;
            else
                student.Name = "Ms." + student.Name;

            return student;
        }

        static Student ConvertToUpper(Student student)
        {
            student.Name = student.Name.ToUpper();
            return student;
        }
    }
}
