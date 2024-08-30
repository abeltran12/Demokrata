using FluentValidation;

namespace Demokrata.Api.Dtos;

public class OperationEmployeeValidation : AbstractValidator<OperationEmployeeDto>
{
    public OperationEmployeeValidation()
    {
        RuleFor(x => x.PrimerNombre)
            .NotEmpty().WithMessage("First name is required.")
            .Matches(@"^[a-zA-Z]+$").WithMessage("The last name cannot contain numbers or special characters.")
            .Length(1, 50).WithMessage("The first name cannot exceed 50 characters in length.");

        RuleFor(x => x.SegundoNombre)
            .Matches(@"^[a-zA-Z]+$").WithMessage("The last name cannot contain numbers or special characters.")
            .MaximumLength(50).WithMessage("The middle name cannot exceed 50 characters in length.");

        RuleFor(x => x.PrimerApellido)
            .NotEmpty().WithMessage("Last name is required.")
            .Matches(@"^[a-zA-Z]+$").WithMessage("The last name cannot contain numbers or special characters.")
            .Length(1, 50).WithMessage("The last name cannot exceed 50 characters in length.");

        RuleFor(x => x.SegundoApellido)
            .Matches(@"^[a-zA-Z]+$").WithMessage("The last name cannot contain numbers or special characters.")
            .MaximumLength(50).WithMessage("The second last name cannot exceed 50 characters in length.");

        RuleFor(x => x.Sueldo)
            .GreaterThan(0).WithMessage("Salary must be greater than zero.");

        RuleFor(x => x.FechaNacimiento)
            .NotEmpty().WithMessage("Birthdate cannot be empty.");
    }
}
