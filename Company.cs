using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> CurrentEmployees { get; set; }

        public Company(string name, DateTime createDate, List<Employee> employees)
        {
            Name = name;
            CreatedOn = createDate;
            CurrentEmployees = employees;
        }

        public void ListEmployees()
        {
            foreach (Employee emp in CurrentEmployees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} has worked for {Name} as {emp.Title} since {emp.StartDate.ToString("d")}.");
            }
        }
    }
}
