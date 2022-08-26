using GenericsBasics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> employees = new List<Employee>();
            //employees.Add(new Employee { Id = 1, Name = "User 1", Email="sree@gmail.com" });
            //employees.Add(new Employee { Id = 2, Name = "User 2", Email = "sree1@gmail.com" });
            //employees.Add(new Employee { Id = 3, Name = "User 3", Email = "sree2@gmail.com" });

            //List<Project> projects = new List<Project>();
            //projects.Add(new Project { ProjectId = 1, Title = "Pr1", Duration = "1" });
            //projects.Add(new Project { ProjectId = 2, Title = "Pr2", Duration = "2" });

            SaveData data = new SaveData();
            //data.Save<Employee>(employees);
            //data.Save<Project>(projects);

            var employees = data.Get<Employee>();
            var projects = data.Get<Project>();


        }
    }
}
