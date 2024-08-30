using AutoMapper;
using Demokrata.Api.Dtos;
using Demokrata.Api.Models;
using Demokrata.Api.Parameters;
using Demokrata.Api.Repositories;
using Demokrata.Api.Services;
using FluentAssertions;
using NSubstitute;

namespace Demokrata.Api.UnitTests.Services;

public class EmployeeServiceTests
{
    private readonly EmployeeService _sut;
    private readonly IEmployeeRepository _repository = Substitute.For<IEmployeeRepository>();
    private readonly IMapper _mapper = Substitute.For<IMapper>();

    public EmployeeServiceTests()
    {
        _sut = new EmployeeService(_repository, _mapper);
    }

    [Fact]
    public async Task FindAllAsync_ShouldReturnPagedResult()
    {
        // Arrange
        var employeeParameters = new EmployeeParameters
        {
            PageSize = 10,
            PageNumber = 1,
            Name = null
        };

        var employees = new List<Employee>
        {
            new() { Id = 1, PrimerNombre = "Carlos", PrimerApellido = "Gonzalez" },
            new() { Id = 2, PrimerNombre = "Maria", PrimerApellido = "Rodriguez" }
        };

        var employeeDtos = new List<EmployeeDto>
        {
            new() { Id = 1, PrimerNombre = "Carlos", PrimerApellido = "Gonzalez" },
            new() { Id = 2, PrimerNombre = "Maria", PrimerApellido = "Rodriguez" }
        };

        var metaDataResult = new MetaData
        {
            TotalCount = 2,
            PageSize = 5,
            CurrentPage = 1,
            TotalPages = 1
        };

        var pagedList = new PagedList<Employee>(employees, employees.Count, 1, 10)
        {
            MetaData = metaDataResult
        };

        _repository.FindAllAsync(employeeParameters)
           .Returns(pagedList);

        _mapper.Map<IEnumerable<EmployeeDto>>(pagedList)
           .Returns(employeeDtos);

        // Act
        var (list, metaData) = await _sut.FindAllAsync(employeeParameters);

        // Assert
        list.Should().NotBeEmpty();
        list.Should().BeEquivalentTo(employeeDtos);
        metaData.Should().NotBeNull();
        metaData.Should().BeEquivalentTo(metaDataResult);
    }

    [Fact]
    public async Task GetByIdAsync_ShouldReturnAnEmployee()
    {
        // Arrange
        int id = 1;

        Employee employee = new(){ Id = 1, PrimerNombre = "Carlos", PrimerApellido = "Gonzalez" };
        EmployeeDto employeeDto = new() { Id = 1, PrimerNombre = "Carlos", PrimerApellido = "Gonzalez" };

        _repository.GetByIdAsync(1)
           .Returns(employee);

        _mapper.Map<EmployeeDto>(employee)
           .Returns(employeeDto);

        // Act
        var result = await _sut.GetByIdAsync(id);

        // Assert
        result.Should().Be(employeeDto);
    }

    [Fact]
    public async Task CreateAsync_ShouldReturnCreatedEmployeeDto()
    {
        // Arrange
        var operationEmployeeDto = new OperationEmployeeDto { PrimerNombre = "Carlos", PrimerApellido = "Gonzalez", FechaNacimiento = DateTime.UtcNow, Sueldo = 2 };
        var employee = new Employee { Id = 1, PrimerNombre = "Carlos", PrimerApellido = "Gonzalez", FechaNacimiento = DateTime.UtcNow, Sueldo = 2 };

        EmployeeDto employeeDto = new() { Id = 1, PrimerNombre = "Carlos", PrimerApellido = "Gonzalez", FechaNacimiento = DateTime.UtcNow, Sueldo = 2 };

        _mapper.Map<Employee>(operationEmployeeDto)
           .Returns(employee);

        _mapper.Map<EmployeeDto>(employee)
           .Returns(employeeDto);

        _repository.CreateAsync(employee).Returns(Task.CompletedTask);

        // Act
        var result = await _sut.CreateAsync(operationEmployeeDto);

        // Assert
        result.Should().Be(employeeDto);
    }

    [Fact]
    public async Task UpdateAsync_ShouldUpdateUser()
    {
        // Arrange
        var operationEmployeeDto = new OperationEmployeeDto { PrimerNombre = "Carlos", PrimerApellido = "Gonzalez", FechaNacimiento = DateTime.UtcNow, Sueldo = 2 };
        var employee = new Employee { Id = 1, PrimerNombre = "Carlos", PrimerApellido = "Gonzalez", FechaNacimiento = DateTime.UtcNow, Sueldo = 2 };

        EmployeeDto employeeDto = new() { Id = 1, PrimerNombre = "Carlos", PrimerApellido = "Gonzalez", FechaNacimiento = DateTime.UtcNow, Sueldo = 2 };

        _mapper.Map<Employee>(operationEmployeeDto)
           .Returns(employee);

        _mapper.Map<EmployeeDto>(employee)
           .Returns(employeeDto);

        _repository.GetByIdAsync(1)
            .Returns(employee);

        _repository.Update(employee).Returns(Task.CompletedTask);

        // Act
        await _sut.Update(1, operationEmployeeDto);

        // Assert
        await _repository.Received(1).Update(Arg.Is<Employee>(e => e.Id == 1));
    }

    [Fact]
    public async Task Delete_ShouldDeleteUserWhenExist()
    {
        // Arrange
        int id = 1;

        Employee employee = new() { Id = 1, PrimerNombre = "Carlos", PrimerApellido = "Gonzalez" };

        _repository.GetByIdAsync(1)
           .Returns(employee);

        // Act
        await _sut.Delete(id);

        // Assert
        await _repository.Received(1).Delete(Arg.Is<Employee>(e => e.Id == 1));
    }
}
