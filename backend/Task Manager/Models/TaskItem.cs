using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Manager.Models
{
	public class TaskItem
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public bool IsCompleted { get; set; } = false;
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
	}
}
