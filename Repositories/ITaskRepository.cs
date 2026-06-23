using TaskManagementAPI.Models;

namespace TaskManagementAPI.Repositories
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetAllAsync();

        Task<TaskItem?> GetByIdAsync(int id);

        Task<TaskItem> CreateAsync(TaskItem task);

        Task<TaskItem?> UpdateAsync(TaskItem task);

        Task<bool> DeleteAsync(int id);
    }
}
