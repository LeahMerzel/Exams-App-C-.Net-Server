using Microsoft.AspNetCore.Mvc;

public interface IGenericController<T>
{
    Task<ActionResult<T>> Create([FromBody] T entity);
    Task<IActionResult> Delete(string id);
    Task<ActionResult<IEnumerable<T>>> GetAll();
    Task<ActionResult<T>> GetById(string id);
    ActionResult<Guid> GetEntityId(T entity);
    Task<IActionResult> Update(T entity);
}