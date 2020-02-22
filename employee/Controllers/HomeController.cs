using employee.Models.Data;
using employee.Models.Interfaces;
using employee.ViewModels;
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
            HomeDetailsViewModels hdvm=new HomeDetailsViewModels(){
                Employee=employeeRepository.GetEmployee(1),
                PageTitle="Details"
            };
            return View(hdvm);
        }
    }
}