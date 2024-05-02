namespace TaskApi.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public datetime DueDate { get; set; }
        public bool IsComplete { get; set; }
    }
}