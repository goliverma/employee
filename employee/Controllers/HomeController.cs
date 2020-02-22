using employee.Models.Data;
using employee.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace employee.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public string Index()
        {
            string st= employeeRepository.GetEmployee(1).Name;
            return st;
        }
        public IActionResult Details()
        {
            Employee employee = employeeRepository.GetEmployee(1);
            return View(employee);
        }
    }
}