namespace EmployeeManagementAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

using EmployeeManagementAPI.Models;
   
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Mahesh",
                    Department = "IT",
                    Salary = 50000
                },
                new Employee
                {
                    Id = 2,
                    Name = "Ramesh",
                    Department = "HR",
                    Salary = 45000
                },
                new Employee
                {
                    Id = 3,
                    Name = "Suresh",
                    Department = "Finance",
                    Salary = 60000
                }
            };

            return Ok(employees);
        }
    }
