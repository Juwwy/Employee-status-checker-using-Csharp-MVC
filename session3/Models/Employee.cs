using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace session3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }

        public bool Confirmed { get; set; } = false;

        //private static int nextId = 1;

        //public Employee()
        //{
        //    Id = nextId;
        //    //FirstName = firstName;
        //    //LastName = lastName;
        //    //Salary = salary;
        //    //Department = dept;
        //    nextId++;
        //}
        //string firstName, string lastName, decimal salary, string dept

    }
}
