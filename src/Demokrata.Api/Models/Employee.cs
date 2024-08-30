using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demokrata.Api.Models;

public class Employee
{
    public  int Id { get; set; }

    [MaxLength(50)]
    public required string PrimerNombre { get; set; }

    [MaxLength(50)]
    public string? SegundoNombre { get; set; }

    [MaxLength(50)]
    public required string PrimerApellido { get; set; }

    [MaxLength(50)]
    public string? SegundoApellido { get; set; }

    public DateOnly FechaNacimiento { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Sueldo { get; set; }
}
