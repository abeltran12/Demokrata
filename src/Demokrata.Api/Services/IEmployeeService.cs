using Demokrata.Api.Dtos;

namespace Demokrata.Api.Services;

public interface IEmployeeService
{
    Task<List<EmployeeDto>> FindAllAsync();
    Task<EmployeeDto?> GetByIdAsync(int id);
    Task<EmployeeDto> CreateAsync(CreateEmployeeDto employee);
    Task Update(int id, UpdateEmployeeDto employee);
    Task Delete(int id);
}
