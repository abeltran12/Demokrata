using Demokrata.Api.Models;

namespace Demokrata.Api.Repositories;

public static class EmployeeRepositoryExtensions
{
    public static IQueryable<Employee> SearchByName(this IQueryable<Employee> employees, string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return employees;

        var lowerCaseTerm = searchTerm.Trim().ToLower();
        return employees.Where(
            t => t.PrimerNombre.Contains(lowerCaseTerm) ||
             t.PrimerApellido.Contains(lowerCaseTerm));
    }
}
