using Demokrata.Api.DemokrataContext.Interceptors;
using Demokrata.Api.DemokrataContext.Mapping;
using Demokrata.Api.DemokrataContext.Seeders;
using Demokrata.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Demokrata.Api.DemokrataContext;

public class DemokrataDbContext(DbContextOptions<DemokrataDbContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new EmployeeMapping());
        EmployeeSeeder.Seed(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.AddInterceptors(new SaveChangesInterceptor());
    }
}
