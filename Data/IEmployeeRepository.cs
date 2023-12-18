using Microsoft.AspNetCore.JsonPatch;
using StaffManagement.Models;

namespace StaffManagement.Data
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();

        Task<Employee> GetEmployeeByIdAsync(int id);

        Task<Employee> AddEmployeeAsync(Employee employee);

        Task<Employee> DeleteEmployeeAsync(int id);

        Task<Employee> UpdateEmployeeAsync(int id, Employee employee);

        Task<Employee> UpdateEmployeePatchAsync(int id, JsonPatchDocument employee);
    }
}
