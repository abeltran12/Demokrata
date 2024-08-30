namespace Demokrata.Api.Dtos;

public class UpdateEmployeeDto
{
    public required string PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public required string PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public DateOnly FechaNacimiento { get; set; }

    public decimal Sueldo { get; set; }
}
