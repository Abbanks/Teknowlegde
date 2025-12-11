using Microsoft.EntityFrameworkCore;
using Teknowlegde.Data.Entity;
using Teknowlegde.Models.Enum;

namespace Teknowlegde.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = new Guid("E244FC80-9AC4-44F7-9E6D-F29D207242E6"),
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@company.com",
                    Department = Department.IT
                },
                new Employee
                {
                    Id = new Guid("80B8344A-F3E9-44E8-8449-0576A44FA788"),
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@company.com",
                    Department = Department.HR
                }
            );
        }
    }
}
