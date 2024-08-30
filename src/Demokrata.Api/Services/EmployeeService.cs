using AutoMapper;
using Demokrata.Api.Dtos;
using Demokrata.Api.Models;
using Demokrata.Api.Repositories;

namespace Demokrata.Api.Services;

public class EmployeeService(IEmployeeRepository repository, IMapper mapper) : IEmployeeService
{
    private readonly IEmployeeRepository _repository = repository;
    private readonly IMapper _mapper = mapper;

    public async Task<List<EmployeeDto>> FindAllAsync()
    {
        var response = await _repository.FindAllAsync();

        var mapResponse = _mapper.Map<IEnumerable<EmployeeDto>>(response);
        return mapResponse.ToList();
    }

    public async Task<EmployeeDto?> GetByIdAsync(int id)
    {
        var response = await _repository.GetByIdAsync(id);

        var mapResponse = _mapper.Map<EmployeeDto>(response);
        return mapResponse;
    }
    public Task<EmployeeDto> CreateAsync(CreateEmployeeDto employee)
    {
        throw new NotImplementedException();
    }

    public Task Update(int id, UpdateEmployeeDto employee)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }
}
