
using System;
using System.Collections.Generic;


namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Company Averitt = new Company("Averitt", now);

            Employee rusty = new Employee("Rusty","Jones","Dock",now);
            Averitt.EmployeeList.Add(rusty);

            // Employee twon = new Employee() {
            //     FirstName = "Twon",
            //     LastName = "Collins",
            //     Title = "Billing",
            //     StartDate = now
            // };
            // Averitt.EmployeeList.Add(twon);

            // Employee pat = new Employee() {
            //     FirstName = "Pat",
            //     LastName = "Smith",
            //     Title = "Cleaning Lady",
            //     StartDate = now
            // };
            // Averitt.EmployeeList.Add(pat);

            Averitt.ListEmployees();
        }
    }
}