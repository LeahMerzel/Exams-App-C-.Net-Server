using Exams_App_C__.Net_Server.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class GenericController<T> : ControllerBase, IGenericController<T>
{
    protected readonly IGenericRepository<T> repository;

    public GenericController(IGenericRepository<T> repository)
    {
        this.repository = repository;
    }

    [Route("get-all")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<T>>> GetAll()
    {
        try
        {
            var entities = await repository.GetAllAsync();
            return Ok(entities);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("get-by-id/{Id}")]
    public async Task<ActionResult<T>> GetById(string id)
    {
        var entity = await repository.GetAsync(id);

        if (entity == null)
        {
            return NotFound();
        }

        return Ok(entity);
    }


    [HttpPost("create")]
    public async Task<ActionResult<T>> Create([FromBody] T entity)
    {
        if (entity == null)
        {
            return BadRequest();
        }

        await repository.AddAsync(entity);
        return CreatedAtAction(nameof(GetById), new { id = GetEntityId(entity) }, entity);
    }

    [HttpPut("update")]
    public async Task<IActionResult> Update(T entity)
    {
        try
        {
            await repository.UpdateAsync(entity);
            return Ok("Entity updated successfully");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error occurred: {ex.Message}");
        }
    }

    [HttpDelete("delete-{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        if (id != null)
        {
            await repository.DeleteAsync(id);
            return Ok();
        }
        else return NotFound();
    }


    [HttpGet("get-entity-id")]
    public ActionResult<Guid> GetEntityId(T entity)
    {
        try
        {
            var entityId = repository.GetEntityId(entity);
            return Ok(entityId);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error occurred: {ex.Message}");
        }
    }

}
