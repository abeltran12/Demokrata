using Demokrata.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demokrata.Api.DemokrataContext.Mapping;

public class EmployeeMapping : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property<DateTime>("FechaCreacion")
            .IsRequired().HasColumnName("FechaCreacion");
        builder.Property<DateTime>("FechaModificacion")
            .IsRequired().HasColumnName("FechaModificacion");
    }
}
