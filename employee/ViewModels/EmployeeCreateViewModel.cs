using employee.Models.Data;
using Microsoft.AspNetCore.Http;

namespace employee.ViewModels
{
    public class EmployeeCreateViewModel : Employee
    {
        public IFormFile Photo { get; set; }
    }
}