using Demokrata.Api.Dtos;
using Demokrata.Api.Models;
using Demokrata.Api.Repositories;
using Demokrata.Api.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demokrata.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController(IEmployeeService service) : ControllerBase
{
    private readonly IEmployeeService _service = service;

    // GET: api/<EmployeesController>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _service.FindAllAsync());
    }

    // GET api/<EmployeesController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    // POST api/<EmployeesController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateEmployeeDto value)
    {
        await _service.CreateAsync(value);
        return Ok(value);
    }

    // PUT api/<EmployeesController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] UpdateEmployeeDto value)
    {
        await _service.Update(id, value);
        return NoContent();
    }

    // DELETE api/<EmployeesController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.Delete(id);
        return NoContent();
    }
}
