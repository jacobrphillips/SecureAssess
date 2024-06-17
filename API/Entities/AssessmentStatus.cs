namespace API.Entities
{
    public class AssessmentStatus
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public AppUser UpdatedBy { get; set; }
        public int UpdatedById { get; set; }
        public Assessment Assessment { get; set; }
        public int AssessmentId { get; set; }
    }

    public enum Status
    {
        Passed,
        Failed,
        MoreInformationRequired,
        Scoring,
        Answering
    }

}