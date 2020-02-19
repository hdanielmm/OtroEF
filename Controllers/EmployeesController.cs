using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OtroEF.Models;

namespace OtroEF.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly OtroEFContext _context;

        public EmployeesController(OtroEFContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            return _context.Employees;
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id){
            var employee = _context.Employees.Find(id);

            if (employee == null){
                return NotFound();
            }

            return employee;
        }
    }
}