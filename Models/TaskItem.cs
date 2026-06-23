namespace TaskManagementAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Status { get; set; } = "Todo";

        public string Priority { get; set; } = "Medium";

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int UserId { get; set; }
    }
}
