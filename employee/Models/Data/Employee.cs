using System.ComponentModel.DataAnnotations;

namespace employee.Models.Data
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Dept? Department { get; set; }
        [Required]
        public string Email { get; set; }
    }
}