using System.Collections.Generic;
using employee.Models.Data;

namespace employee.Models.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee employee);
    }
}