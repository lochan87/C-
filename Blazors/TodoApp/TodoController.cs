using Microsoft.AspNetCore.Mvc;
using TodoApp.Server.Services;
using TodoApp.Shared;

namespace TodoApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly MongoDbService _service;

        public TodoController(MongoDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<TodoItem>> Get() => await _service.GetAsync();

        [HttpPost]
        public async Task<IActionResult> Post(TodoItem item)
        {
            await _service.CreateAsync(item);
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, TodoItem item)
        {
            var existing = await _service.GetByIdAsync(id);
            if (existing == null) return NotFound();
            item.Id = id;
            await _service.UpdateAsync(id, item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var existing = await _service.GetByIdAsync(id);
            if (existing == null) return NotFound();
            await _service.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetById(string id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item == null)
                return NotFound();

            return item;
        }
    }
}
