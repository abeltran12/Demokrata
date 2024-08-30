using Demokrata.Api.Dtos;
using Demokrata.Api.Parameters;

namespace Demokrata.Api.Services;

public interface IEmployeeService
{
    Task<(List<EmployeeDto> list, MetaData metaData)> FindAllAsync(EmployeeParameters parameters);
    Task<EmployeeDto?> GetByIdAsync(int id);
    Task<EmployeeDto> CreateAsync(OperationEmployeeDto request);
    Task Update(int id, OperationEmployeeDto request);
    Task Delete(int id);
}
