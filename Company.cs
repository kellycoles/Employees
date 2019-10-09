using System;
using System.Collections.Generic;

namespace Employees {
    public class Company {
        public string Name { get; }
        public DateTime CreatedDate { get; }
        public List<Employee> EmployeeList = new List<Employee> ();
        //constructor
        public Company (string name, DateTime dateCreated) {
            Name = name;
            CreatedDate = dateCreated;
        }
        public void ListEmployees () {
            foreach (Employee employee in EmployeeList) {
                Console.WriteLine ($"{employee.FirstName} {employee.LastName} works at {Name} as {employee.Title} since {employee.StartDate}");
            }
        }

    }
}