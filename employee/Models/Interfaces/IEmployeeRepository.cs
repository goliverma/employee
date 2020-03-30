using System.Collections.Generic;
using System.Threading.Tasks;
using employee.Models.Data;

namespace employee.Models.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployee(int id);
        Task<IEnumerable<Employee>> GetAllEmployee();
        Task<Employee> Add(Employee employee);
        Task<Employee> Update(Employee employeechange);
        Task<Employee> Delete(int id);
    }
}