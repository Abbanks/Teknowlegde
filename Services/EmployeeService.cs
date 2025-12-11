using Microsoft.EntityFrameworkCore;
using Teknowlegde.Data;
using Teknowlegde.Data.Entity;
using Teknowlegde.Models;
using Teknowlegde.Services.Interface;

namespace Teknowlegde.Services
{
    public class EmployeeService(ApplicationDbContext context) : IEmployeeService
    {
        public async Task<IEnumerable<EmployeeViewModel>> GetAllEmployeesAsync()
        {
            return await context.Employees.Select(e => new EmployeeViewModel
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Email = e.Email,
                    Department = e.Department
                }).ToListAsync();
        }

        public async Task<EmployeeViewModel?> GetEmployeeByIdAsync(Guid id)
        {
            var employee = await context.Employees.FindAsync(id);

            if (employee == null)
                return null;

            return MapToViewModel(employee);
        }

        public async Task<Guid> CreateEmployeeAsync(EmployeeViewModel model)
        {
            var employee = MapToEntity(model);
            employee.Id = Guid.NewGuid();
            context.Employees.Add(employee);
            await context.SaveChangesAsync();

            return employee.Id;
        }

        public async Task<bool> UpdateEmployeeAsync(EmployeeViewModel model)
        {
            var employee = await context.Employees.FindAsync(model.Id);

            if (employee == null)
                return false;

            employee.FirstName = model.FirstName;
            employee.LastName = model.LastName;
            employee.Email = model.Email;
            employee.Department = model.Department;

            context.Employees.Update(employee);
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteEmployeeAsync(Guid id)
        {
            var employee = await context.Employees.FindAsync(id);

            if (employee == null)
                return false;

            context.Employees.Remove(employee);
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EmployeeExistsAsync(Guid id)
        {
            return await context.Employees.AnyAsync(e => e.Id == id);
        }

        private static EmployeeViewModel MapToViewModel(Employee entity)
        {
            return new EmployeeViewModel
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                Department = entity.Department
            };
        }

        private static Employee MapToEntity(EmployeeViewModel model)
        {
            return new Employee
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Department = model.Department
            };
        }
    }
}