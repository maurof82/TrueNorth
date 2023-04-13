using Microsoft.EntityFrameworkCore;

namespace Exercise_Backend.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext (DbContextOptions<TaskContext> options)
: base(options)
{
        }

        public DbSet<Exercise_Backend.Models.Task> Task { get; set; }
    }
}
