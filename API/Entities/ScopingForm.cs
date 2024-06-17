namespace API.Entities
{
    public class ScopingForm
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateSubmitted { get; set; } = DateTime.UtcNow;
        public Assessment Assessment { get; set; }
        public int AssessmentId { get; set; }
        public List<Sample> Samples { get; set; } = new List<Sample>();
    }
}