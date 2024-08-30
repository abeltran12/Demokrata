using Demokrata.Api.Models;

namespace Demokrata.Api.Repositories;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> FindAllAsync();
    Task<Employee?> GetByIdAsync(int id);
    Task CreateAsync(Employee employee);
    Task Update(Employee employee);
    Task Delete(Employee employee);
}
