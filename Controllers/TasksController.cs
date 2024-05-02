// Controllers/TasksController.cs
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;

[Route("api/[controller]")]
[ApiController]
public class TasksController : ControllerBase
{
    private readonly TaskRepository _taskRepository;

    public TasksController(TaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    [HttpGet]
    public IActionResult GetAllTasks()
    {
        var tasks = _taskRepository.GetAllTasks();
        return Ok(tasks);
    }

    [HttpGet("{id}")]
    public IActionResult GetTaskById(int id)
    {
        var task = _taskRepository.GetTaskById(id);
        if (task == null)
            return NotFound();

        return Ok(task);
    }

    [HttpPost]
    public IActionResult AddTask(Task task)
    {
        _taskRepository.AddTask(task);
        return Ok("Task added successfully");
    }

    [HttpPut("{id}")]
    public IActionResult UpdateTask(int id, Task task)
    {
        if (id != task.Id)
            return BadRequest();

        _taskRepository.UpdateTask(task);
        return Ok("Task updated successfully");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTask(int id)
    {
        _taskRepository.DeleteTask(id);
        return Ok("Task deleted successfully");
    }
}
