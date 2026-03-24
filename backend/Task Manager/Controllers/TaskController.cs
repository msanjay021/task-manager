using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_Manager.Data;
using Task_Manager.Models;

namespace Task_Manager.Controllers
{
	[ApiController]
	[Route("api/tasks")]
	public class TaskController : ControllerBase
	{
		private readonly AppDbContext _context;
		public TaskController(AppDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<IActionResult> GetTasks()
		{
			return Ok(await _context.Tasks.ToListAsync());
		}

		[HttpPost]
		public async Task<IActionResult> AddTask(TaskItem task)
		{
			if (task == null)
			{
				task.Title = "temp";
				task.IsCompleted = false;
			}
			_context.Tasks.Add(task);
			await _context.SaveChangesAsync();
			return Ok(task);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateTask(int id, TaskItem updatedTask)
		{
			var task = await _context.Tasks.FindAsync(id);
			task.Title = updatedTask.Title;
			task.IsCompleted = updatedTask.IsCompleted;
			await _context.SaveChangesAsync();
			
			return Ok(task);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTask(int id)
		{
			var task = await _context.Tasks.FindAsync(id);
			if (task == null) return NotFound();

			_context.Tasks.Remove(task);
			await _context.SaveChangesAsync();
			return Ok();
		}
	}
}
