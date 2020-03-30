using employee.Models.Data;
using employee.Models.Repository;
using Microsoft.EntityFrameworkCore;

namespace employee.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Seed();
        // }
    }
}