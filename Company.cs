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
    }
}
