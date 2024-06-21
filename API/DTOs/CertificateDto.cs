namespace API.DTOs
{
    public class CertificateDto
    {
        public int Id { get; set; }
        public int AssessmentId { get; set; }
        public AssessmentType Type { get; set; }
        public DateTime AwardDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}