using Teknowlegde.Models;

namespace Teknowlegde.Services.Interface
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeViewModel>> GetAllEmployeesAsync();
        Task<EmployeeViewModel> GetEmployeeByIdAsync(Guid id);
        Task<Guid> CreateEmployeeAsync(EmployeeViewModel model);
        Task<bool> UpdateEmployeeAsync(EmployeeViewModel model);
        Task<bool> DeleteEmployeeAsync(Guid id);
        Task<bool> EmployeeExistsAsync(Guid id);
    }
}
