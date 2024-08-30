using Demokrata.Api.Dtos;
using Demokrata.Api.Models;
using Demokrata.Api.Parameters;
using Demokrata.Api.Repositories;
using Demokrata.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demokrata.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController(IEmployeeService service) : ControllerBase
{
    private readonly IEmployeeService _service = service;

    // GET: api/<EmployeesController>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PagedList<EmployeeDto>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(CustomProblemDetail))]
    public async Task<IActionResult> Get([FromQuery] EmployeeParameters parameters)
    {
        var (employees, metaData) = await _service.FindAllAsync(parameters);
        Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(metaData));

        return Ok(employees);
    }

    // GET api/<EmployeesController>/5
    [HttpGet("{id}", Name = "GetById")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EmployeeDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(CustomProblemDetail))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(CustomProblemDetail))]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    // POST api/<EmployeesController>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(EmployeeDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(CustomProblemDetail))]
    public async Task<IActionResult> Post([FromBody] OperationEmployeeDto value)
    {
        var response = await _service.CreateAsync(value);
        return CreatedAtRoute(nameof(GetById), new { id = response.Id }, response);
    }

    // PUT api/<EmployeesController>/5
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(CustomProblemDetail))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(CustomProblemDetail))]
    public async Task<IActionResult> Put(int id, [FromBody] OperationEmployeeDto value)
    {
        await _service.Update(id, value);
        return NoContent();
    }

    // DELETE api/<EmployeesController>/5
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(CustomProblemDetail))]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.Delete(id);
        return NoContent();
    }
}
