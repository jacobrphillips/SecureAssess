
namespace API.Entities
{
    public class Certificate
    {
        public int Id { get; set; }
        public int AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public AssessmentType Type { get; set; }
        public DateTime AwardDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}