using Demokrata.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Demokrata.Api.DemokrataContext.Interceptors;

public class SaveChangesInterceptor : ISaveChangesInterceptor
{
    public async ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        if (eventData.Context is not DemokrataDbContext contex) return result;

        var tracker = contex!.ChangeTracker;

        var entries = tracker
                .Entries<Employee>()
                .Where(g => g.State == EntityState.Modified || g.State == EntityState.Added);

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Property<DateTime>("FechaModificacion").CurrentValue = DateTime.UtcNow;
            }

            if (entry.State == EntityState.Added)
            {
                entry.Property<DateTime>("FechaCreacion").CurrentValue = DateTime.UtcNow;
                entry.Property<DateTime>("FechaModificacion").CurrentValue = DateTime.UtcNow;
            }
        }

        return await ValueTask.FromResult(result);
    }
}
