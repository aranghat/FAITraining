using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    public interface IOptionalServices
    {
        void TakeWorkFromHome(DateTime dateTime);
    }

    public abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }

        public abstract void ApplyForLeave();
    }

    public class JSE : Employee
    {
        public override void ApplyForLeave()
        {
            Console.WriteLine("Sending application to project Manager");
        }
    }

    public class ProjectManager : Employee,IOptionalServices
    {
        public override void ApplyForLeave()
        {
            Console.WriteLine("Sending Application to HR");
        }

        public void TakeWorkFromHome(DateTime dateTime)
        {
            Console.WriteLine("Working from home today");
        }
    }

    public class HR : Employee ,IOptionalServices
    {
        public override void ApplyForLeave()
        {
            Console.WriteLine("Applying for leave in self service portal");
        }

        public void TakeWorkFromHome(DateTime dateTime)
        {
            Console.WriteLine("Working from home today");
        }
    }
}
