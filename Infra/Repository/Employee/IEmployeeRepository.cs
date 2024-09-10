using Banquinho.Models.Response;
using Banquinho.Models.Employeeses;

namespace Banquinho.Infra.Repository.Employee;

public interface IEmployeeRepository
{
    Task<ServiceResponse<List<Employees>>> GetEmployeesAsync();
    Task<ServiceResponse<Employees>> GetEmployeesByIdAsync(Guid id);
    Task<ServiceResponse<List<Employees>>> CreateEmployeesReturnListAsync(Employees employee);
    Task<ServiceResponse<Employees>> CreateEmployeesAsync(Employees employee); // return only employee
    Task<ServiceResponse<List<Employees>>> DeleteEmployeesByIdReturnListAsync(Guid id);
    Task<ServiceResponse<Employees>> DeleteEmployeesAsync(Guid id);
    Task<ServiceResponse<Employees>> UpdateEmployeesAsync(Employees employee);
    Task<ServiceResponse<List<Employees>>> UpdateEmployeesReturnListAsync(Employees employee);
}