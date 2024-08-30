using Demokrata.Api.Models;
using Demokrata.Api.Parameters;

namespace Demokrata.Api.Repositories;

public interface IEmployeeRepository
{
    Task<PagedList<Employee>> FindAllAsync(EmployeeParameters parameters);
    Task<Employee?> GetByIdAsync(int id);
    Task CreateAsync(Employee employee);
    Task Update(Employee employee);
    Task Delete(Employee employee);
}
