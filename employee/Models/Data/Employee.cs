namespace employee.Models.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dept Department { get; set; }
        public string Email { get; set; }
    }
}