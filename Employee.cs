using System;

namespace Employees
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
                //constructor
        public Employee (string fname, string lname, string title, DateTime startDate) {
            FirstName = fname;
            LastName = lname;
            Title = title;
            StartDate = startDate;
        }
    }
}