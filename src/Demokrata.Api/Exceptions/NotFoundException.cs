namespace Demokrata.Api.Exceptions;

public class NotFoundException(string name, object key) : Exception($"The {name} with key ({key}) doesnt exist.")
{
}
