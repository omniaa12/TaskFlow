using Microsoft.AspNetCore.Mvc;
using TaskFlow.Data;
using TaskFlow.Models;

namespace TaskFlow.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        

        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetAllTasks()
        {
          
            return Ok(InMemoryDB.taskFlows);
        }
    }
}
