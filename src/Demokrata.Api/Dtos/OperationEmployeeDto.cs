namespace Demokrata.Api.Dtos;

public class OperationEmployeeDto
{
    public required string PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public required string PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public decimal Sueldo { get; set; }
}
