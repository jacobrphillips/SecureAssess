namespace API.Entities
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public string Activity { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public AppUser User { get; set; }
        public int UserId { get; set; }
    }
}