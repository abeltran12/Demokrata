using AutoMapper;
using Demokrata.Api.Dtos;
using Demokrata.Api.Models;

namespace Demokrata.Api.Profiles;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<Employee, EmployeeDto>().ReverseMap();
        CreateMap<OperationEmployeeDto, Employee>();
    }
}
