using EMS.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS.Data
{
    public class EmployeeDbContext : DbContext
    {

        // define the database and structure of the database will be managed over here

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=EmployeeDB;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>().HasData(
    new Department
    {
        Name = "Administrator",
        DepartmentId = 1,
    });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Name = "Administrator",
                    Id = 1,
                    Email = "test",
                    Phone = "test",
                    
                    DepartmentId = 1,
                });
            base.OnModelCreating(modelBuilder);
        }

        // tables in db and entites in application mapping 
        public DbSet<Employee> Employees { get; set; } // plural many

        public DbSet<Department> Departments { get; set; }
    }
}
