using FluentValidation.Results;

namespace Demokrata.Api.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message) { }

    public BadRequestException(string message, ValidationResult validation) : base(message)
    {
        Errors = validation.ToDictionary();
    }

    public IDictionary<string, string[]> Errors { get; set; }
}
