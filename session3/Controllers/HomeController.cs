using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using session3.Models;
using session3.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace session3.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeService employeeService;

        public HomeController(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public IActionResult Index()
        {
            //return View(employeeService.GetEmployee()); OR
            IEnumerable<Employee> employee = employeeService.GetEmployees();
            return View(employee);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Employee());
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            //employeeService.AddEmployee(employee);
            Employee employee1 = new Employee //Trying to do model binding instead of letting asp do that for us
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Department = employee.Department,
                Salary = employee.Salary

            };

            employeeService.AddEmployee(employee1);

            return RedirectToAction("Index");
        }

        public IActionResult Employee(int id)
        {
            Employee empInfo = employeeService.GetEmployee(id);

            return View(empInfo);
            //return $"hello {id}";
        }

        public IActionResult Check(int id)
        {
            var CheckStat = employeeService.GetEmployee(id);
            CheckStat.Confirmed = true;
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
