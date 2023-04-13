using System.ComponentModel.DataAnnotations;

namespace Exercise_Backend.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }       
        public string Title { get; set; }
        public bool IsDone { get; set; } = false;
    }
}
