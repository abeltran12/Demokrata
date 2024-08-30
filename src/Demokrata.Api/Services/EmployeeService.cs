using AutoMapper;
using Demokrata.Api.Dtos;
using Demokrata.Api.Exceptions;
using Demokrata.Api.Models;
using Demokrata.Api.Parameters;
using Demokrata.Api.Repositories;

namespace Demokrata.Api.Services;

public class EmployeeService(IEmployeeRepository repository, IMapper mapper) : IEmployeeService
{
    private readonly IEmployeeRepository _repository = repository;
    private readonly IMapper _mapper = mapper;

    public async Task<(List<EmployeeDto> list, MetaData metaData)> FindAllAsync(EmployeeParameters parameters)
    {
        var response = await _repository.FindAllAsync(parameters);

        var mapResponse = _mapper.Map<IEnumerable<EmployeeDto>>(response);
        return (mapResponse.ToList(), metaData: response.MetaData);
    }

    public async Task<EmployeeDto?> GetByIdAsync(int id)
    {
        var response = await _repository.GetByIdAsync(id) ?? throw new NotFoundException("employee", id);
        var mapResponse = _mapper.Map<EmployeeDto>(response);
        return mapResponse;
    }
    public async Task<EmployeeDto> CreateAsync(OperationEmployeeDto request)
    {
        var validator = new OperationEmployeeValidation();
        var validatorResult = await validator.ValidateAsync(request);

        if (validatorResult.Errors.Any())
            throw new BadRequestException("Employee invalid", validatorResult);

        var employee = _mapper.Map<Employee>(request);

        await _repository.CreateAsync(employee);

        return _mapper.Map<EmployeeDto>(employee);
    }

    public async Task Update(int id, OperationEmployeeDto request)
    {
        var validator = new OperationEmployeeValidation();
        var validatorResult = await validator.ValidateAsync(request);

        if (validatorResult.Errors.Any())
            throw new BadRequestException("Employee invalid", validatorResult);

        var employee = await _repository.GetByIdAsync(id) ?? throw new NotFoundException("Employee", id);
        _mapper.Map(request, employee);
        await _repository.Update(employee);
    }

    public async Task Delete(int id)
    {
        var employee = await _repository.GetByIdAsync(id) ?? throw new NotFoundException("Employee", id);
        await _repository.Delete(employee);
    }
}
