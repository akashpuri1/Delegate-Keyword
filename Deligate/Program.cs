using System;
using System.Collections.Generic;

namespace Deligate
{
    public class Program
    {
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { Id = 1, Name = "Akash", Experience = 5 });
            emplist.Add(new Employee() { Id = 2, Name = "Jatin", Experience = 2 });
            emplist.Add(new Employee() { Id = 3, Name = "Jasjot", Experience = 4 });
            emplist.Add(new Employee() { Id = 4, Name = "Karan", Experience = 1 });

            Employee.PromoteEmployee(emplist, x => x.Experience >= 4);
        }
    }

    delegate bool IsPromotable(Employee emp1);

    class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Experience { set; get; }

        public static void PromoteEmployee(List<Employee> emp, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in emp)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine("Employee" + " " + employee.Name + " " + "is Promoted!");
                }
            }
        }
    }
}