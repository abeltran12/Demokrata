using Demokrata.Api.Models;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace Demokrata.Api.Exceptions;

public class ExceptionMiddleware() : IExceptionHandler
{

    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
        httpContext.Response.ContentType = "application/json";
        CustomProblemDetail problem = new();

        switch (exception)
        {
            case BadRequestException badRequestException:
                statusCode = HttpStatusCode.BadRequest;
                problem = new CustomProblemDetail
                {
                    Title = badRequestException.Message,
                    Status = (int)statusCode,
                    Errors = badRequestException.Errors!,
                    Detail = badRequestException.InnerException?.Message,
                    Type = nameof(BadRequestException)
                };
                break;
            case NotFoundException NotFound:
                statusCode = HttpStatusCode.NotFound;
                problem = new CustomProblemDetail
                {
                    Title = NotFound.Message,
                    Status = (int)statusCode,
                    Type = nameof(NotFoundException),
                    Detail = NotFound.InnerException?.Message
                };
                break;
            default:
                problem = new CustomProblemDetail
                {
                    Title = exception.Message,
                    Status = (int)statusCode,
                    Type = nameof(HttpStatusCode.InternalServerError),
                    Detail = exception.StackTrace
                };
                break;
        }

        httpContext.Response.StatusCode = (int)statusCode;
        await httpContext.Response.WriteAsJsonAsync(problem, cancellationToken: cancellationToken);

        return true;
    }
}
