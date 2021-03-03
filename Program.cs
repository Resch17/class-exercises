using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company centralPerk = new Company("Central Perk Enterprises", new DateTime(1994, 5, 23), new List<Employee>());
            // Create three employees
            Employee joey = new Employee("Joey", "Tribbiani", "CEO", new DateTime(1994, 8, 17));
            Employee chandler = new Employee("Chandler", "Bing", "CFO", new DateTime(1994, 10, 1));
            Employee monica = new Employee("Monica", "Bing", "Janitor", new DateTime(1997, 3, 23));
            // Assign the employees to the company
            centralPerk.CurrentEmployees.Add(joey);
            centralPerk.CurrentEmployees.Add(chandler);
            centralPerk.CurrentEmployees.Add(monica);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            centralPerk.ListEmployees();
        }
    }
}
