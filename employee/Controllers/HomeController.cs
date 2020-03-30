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
        [Obsolete]
        public async Task<IActionResult> Create(EmployeeCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                string uniqueFileName= await ProcessUploadFile(model);
                var data=new EmployeeCreateViewModel{
                    Name=model.Name,
                    Email=model.Email,
                    Department=model.Department,
                    PhotoPath = uniqueFileName
                };
                await employeeRepository.Add(data);
                return RedirectToAction(nameof(Details),new {id = data.Id});
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var data = await employeeRepository.GetEmployee(id);
            var editModel=new EmployeeEditViewModel{
                Id=data.Id,
                Name=data.Name,
                Email=data.Email,
                Department=data.Department,
                ExistingPhotoPath=data.PhotoPath
            };
            return View(editModel);
        }
        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> Edit(EmployeeEditViewModel model)
        {
            if(ModelState.IsValid)
            {
                var employee = await employeeRepository.GetEmployee(model.Id);
                employee.Name=model.Name;
                employee.Department=model.Department;
                employee.Email=model.Email;
                if(model.Photo != null)
                {
                    if(model.ExistingPhotoPath != null)
                    {
                        string filepath= Path.Combine(hostingEnvironment.WebRootPath,"Images",model.ExistingPhotoPath);
                        System.IO.File.Delete(filepath);
                    }
                    employee.PhotoPath = await ProcessUploadFile(model);
                }
                await employeeRepository.Update(employee);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [Obsolete]
        private async Task<string> ProcessUploadFile(EmployeeCreateViewModel model)
        {
            string uniqueFileName = null;
            if(model.Photo!=null)
            {
                string uploadfolder= Path.Combine(hostingEnvironment.WebRootPath,"Images");
                uniqueFileName = Guid.NewGuid().ToString()+"_"+model.Photo.FileName;
                string filepath= Path.Combine(uploadfolder,uniqueFileName);
                await Task.Run(() => 
                {
                    model.Photo.CopyToAsync(new FileStream(filepath, FileMode.Create));
                });
            }
            return uniqueFileName;
        }
    }
}