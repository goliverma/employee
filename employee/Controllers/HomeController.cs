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
        public IActionResult Index()
        {
            var model=employeeRepository.GetAllEmployee();
            return View(model);
        }
        public IActionResult Details(int? id)
        {
            HomeDetailsViewModels hdvm=new HomeDetailsViewModels(){
                Employee=employeeRepository.GetEmployee(id ?? 1),
                PageTitle="Details"
            };
            return View(hdvm);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if(ModelState.IsValid)
            {
                Employee newemployee=employeeRepository.Add(model);
                return RedirectToAction("details",new {id = newemployee.Id});
            }
            return View();
        }
    }
}