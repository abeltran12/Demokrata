using Microsoft.AspNetCore.Mvc;

namespace Demokrata.Api.Models;

public class CustomProblemDetail : ProblemDetails
{
    public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
}
