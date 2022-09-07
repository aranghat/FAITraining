using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();

            employees.Add(new Employee { Name = "Sree", Age = 36, Gender = Gender.Male, City = "Bengaluru", CTC = 500000 });
            employees.Add(new Employee { Name = "Bill", Age = 47, Gender = Gender.Male, City = "Mumbai", CTC = 900000 });
            employees.Add(new Employee { Name = "Kate", Age = 36, Gender = Gender.Female, City = "Bengaluru", CTC = 1000000 });
            employees.Add(new Employee { Name = "Emma", Age = 52, Gender = Gender.Female, City = "Kochi", CTC = 600000 });

            //List<Employee> ageGroup = new List<Employee>();
            //foreach(var emp in employees)
            //{
            //    if(emp.Age >= 30 && emp.Age <= 40)
            //    {
            //        ageGroup.Add(emp);
            //    }
            //}

            //select * from employees where age >=30 and age<=40
            //var ageGroup = from emp in employees
            //               where emp.Age >= 30
            //               orderby emp.Name ascending
            //               select emp;

            //select Name,Age from employees where city = 'Bengaluru'
            //var data = from emp in employees
            //           where emp.City == "Bengaluru"
            //           select new { EmployeeName=emp.Name, Age=emp.Age };

            //foreach (var e in data)
            //    Console.WriteLine($"{e.EmployeeName}\t{e.Age}");

            //select * from employees where age>=30 and gender = 'MALE' order by name desc
            //var data = employees.Where(d => d.Age >= 30 && d.Gender == Gender.Male)
            //                    .Select(d => new { d.Name, d.Age})
            //                    //.OrderBy(d => d.Name);
            //                    .OrderByDescending(d => d.Name);

            //select * from employees where name like 'S%'
            //var data = employees.Where(d => d.Name.StartsWith("S"));

            //var data = employees.Where(d => d.Name.ToUpper().Contains("E"));


            //foreach (var e in data)
            //    Console.WriteLine(e);

            //List<string> distinctCities = new List<string>();
            //foreach(var emp in employees)
            //{
            //    if (!distinctCities.Contains(emp.City))
            //        distinctCities.Add(emp.City);
            //}

            //select distinct age,city from employees
            //foreach (var city in employees
            //                            .Select(d => new { d.Age, d.City })
            //                            .Distinct())
            //    Console.WriteLine(city);

            //Count
            //Max
            //Min
            //Avg
            //Sum

            //int totalEmployeesInBengaluru = employees.Where(d => d.City=="Bengaluru").Count();
            //Console.WriteLine($"Total Employees : {totalEmployeesInBengaluru}");

            //int maxCTC = employees.Where(d => d.City == "Bengaluru").Select(d => d.CTC).Max();
            //Console.WriteLine($"MAX CTC : {maxCTC}");

            //int sumTotalCTC = employees.Where(d => d.City == "Bengaluru").Sum(d => d.CTC);
            //Console.WriteLine($"Total Salary Paid : {sumTotalCTC}");

            // var emp = employees.First(d => d.City == "Kolkata");
            var emp = employees.Select(d => new { d.Name, d.City, d.CTC }).FirstOrDefault(d => d.City == "Bengaluru");

            if (emp != null)
                Console.WriteLine(emp);
            else
                Console.WriteLine("There are no emplpoyees matching the city");


        }
    }
}
