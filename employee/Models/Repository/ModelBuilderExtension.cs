using employee.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace employee.Models.Repository
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee{
                    Id=7,
                    Name="Himanshi Verma",
                    Email="himanshi@gmail.com",
                    Department=Dept.HR
                }
            );
        }
    }
}