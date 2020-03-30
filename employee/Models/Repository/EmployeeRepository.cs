using System.Collections.Generic;
using System.Threading.Tasks;
using employee.Models.Data;
using employee.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace employee.Models.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public EmployeeRepository(AppDbContext context)
        {
            this.context=context;
        }
        public async Task<Employee> Add(Employee employee)
        {
            await context.Employees.AddAsync(employee);
            await context.SaveChangesAsync();
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {
            return await context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await context.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}