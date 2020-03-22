using System.Collections.Generic;
using System.Linq;
using employee.Models.Data;
using employee.Models.Interfaces;

namespace employee.Models.Mock
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeelist;
        public MockEmployeeRepository()
        {
            employeelist = new List<Employee>(){
                new Employee(){Id=0, Name="Gaurav", Department=Dept.IT, Email="gaurav@gmail.com"},
                new Employee(){Id=1, Name="Gopal", Department=Dept.IT, Email="gopal@gmail.com"},
                new Employee(){Id=2, Name="Gagan", Department=Dept.HR, Email="gagan@gmail.com"},
                new Employee(){Id=3, Name="Yashu", Department=Dept.Payroll, Email="yashu@gmail.com"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id=employeelist.Max(e => e.Id)+1;
            employeelist.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee() => employeelist;

        public Employee GetEmployee(int id)
        {
            var employee=employeelist.FirstOrDefault(e=>e.Id==id);
            return employee;
        }
    }
}