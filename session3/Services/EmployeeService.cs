using session3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace session3.Services
{
    public class EmployeeService
    {
        private static ICollection<Employee> employees;

        public EmployeeService()
        {
            employees = new List<Employee>();
        }

        public IEnumerable<Employee> GetEmployees()     // This method get all employee in list
        {
            return employees.ToList();
        }

        public Employee GetEmployee(int id)   // This method help fetch single employee out of our list
        {
            Employee employee = employees.FirstOrDefault(e => e.Id == id);
            // [or] == > return employees.FirstOrDefault(e => e.Id == id);
            return employee;
        }

        


        public bool RemoveEmployee(int id)
        {
            Employee employee = GetEmployee(id);
            if(employee != null)
            {
                employees.Remove(employee);
                return true;
            }
            return false;
        }

        public void AddEmployee(Employee employee)
        {
            employee.Id = GetNextId();
            employees.Add(employee);
        }

        private int GetNextId()
        {
            // return employees.LastOrDefault().Id; if it is empty then it might return "Null" be careful try second way
            var employee = employees.LastOrDefault();
            if(employee != null)
            {
                return employee.Id + 1;
            } return 1;
        }

    }
}
