using Demokrata.Api.DemokrataContext;
using Demokrata.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Demokrata.Api.Repositories;

public class EmployeeRepository(DemokrataDbContext context) : IEmployeeRepository
{
    private readonly DemokrataDbContext _context = context;

    public async Task<IEnumerable<Employee>> FindAllAsync()
    {
        return _context.Employees.AsNoTracking();
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
        var employees = await GetByIdAsync(11);
        _context.Remove(employee);
        await _context.SaveChangesAsync();
    }
}
