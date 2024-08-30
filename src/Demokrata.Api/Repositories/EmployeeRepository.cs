using Demokrata.Api.DemokrataContext;
using Demokrata.Api.Models;
using Demokrata.Api.Parameters;
using Microsoft.EntityFrameworkCore;

namespace Demokrata.Api.Repositories;

public class EmployeeRepository(DemokrataDbContext context) : IEmployeeRepository
{
    private readonly DemokrataDbContext _context = context;

    public async Task<PagedList<Employee>> FindAllAsync(EmployeeParameters parameters)
    {
        var query = _context.Employees
        .AsNoTracking()
        .SearchByName(parameters.Name ?? string.Empty)
        .OrderBy(x => x.Id);

        var employeeSelect = await query
            .Skip((parameters.PageNumber - 1) * parameters.PageSize)
            .Take(parameters.PageSize)
            .ToListAsync();

        var count = await query.CountAsync();

        return new PagedList<Employee>(employeeSelect, count, parameters.PageNumber, parameters.PageSize);
    }

    public async Task<Employee?> GetByIdAsync(int id)
    {
        return await _context.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task CreateAsync(Employee employee)
    {
        await _context.AddAsync(employee);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Employee employee)
    {
        _context.Update(employee);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Employee employee)
    {
        _context.Remove(employee);
        await _context.SaveChangesAsync();
    }
}
