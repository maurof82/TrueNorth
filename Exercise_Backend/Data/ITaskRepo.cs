using Exercise_Backend.Models;
using System.Collections.Generic;

namespace Exercise_Backend.Data
{
    public interface ITaskRepo
    {
        bool SaveChanges();
        void CreateTask(Task task);
        Task GetTask(int id);
        IEnumerable<Task> GetTasks();
        void UpdateTask(Task task);
    }
}
    