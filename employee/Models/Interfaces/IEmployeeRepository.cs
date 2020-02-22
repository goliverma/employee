using employee.Models.Data;

namespace employee.Models.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id); 
    }
}