using System.Threading.Tasks;
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
        public async Task<IActionResult> Index()
        {
            var model = await employeeRepository.GetAllEmployee();
            return View(model);
        }
        public async Task<IActionResult> Details(int? id)
        {
            HomeDetailsViewModels hdvm=new HomeDetailsViewModels(){
                Employee = await employeeRepository.GetEmployee(id ?? 1),
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
        public async Task<IActionResult> Create(Employee model)
        {
            if(ModelState.IsValid)
            {
                Employee newemployee= await employeeRepository.Add(model);
                return RedirectToAction("details",new {id = newemployee.Id});
            }
            return View();
        }
    }
}