using System;
using System.IO;
using System.Threading.Tasks;
using employee.Models.Data;
using employee.Models.Interfaces;
using employee.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace employee.Controllers
{
    public class HomeController : Controller
    {
        [System.Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;
        private IEmployeeRepository employeeRepository;

        [System.Obsolete]
        public HomeController(IEmployeeRepository employeeRepository, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment=hostingEnvironment;
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
        [System.Obsolete]
        public async Task<IActionResult> Create(EmployeeCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(model.Photo!=null)
                {
                    string uploadfolder= Path.Combine(hostingEnvironment.WebRootPath,"Images");
                    uniqueFileName = Guid.NewGuid().ToString()+"_"+model.Photo.FileName;
                    string filepath= Path.Combine(uploadfolder,uniqueFileName);
                    await model.Photo.CopyToAsync(new FileStream(filepath, FileMode.Create));
                }
                var data=new EmployeeCreateViewModel{
                    Name=model.Name,
                    Email=model.Email,
                    Department=model.Department,
                    PhotoPath = uniqueFileName
                };
                await employeeRepository.Add(data);
                return RedirectToAction("details",new {id = data.Id});
            }
            return View();
        }
    }
}