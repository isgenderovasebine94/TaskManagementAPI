using TaskManagementAPI.Models;

namespace TaskManagementAPI.Services
{
    public interface ITaskService
    {
        Task<List<TaskItem>> GetAllAsync();

        Task<TaskItem?> GetByIdAsync(int id);

        Task<TaskItem> CreateAsync(TaskItem task);

        Task<TaskItem?> UpdateAsync(TaskItem task);

        Task<bool> DeleteAsync(int id);
    }
}
