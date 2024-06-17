
namespace API.DTOs
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<MemberDto> Contacts { get; set; }
        public List<AssessmentDto> Assessments { get; set; }
        public List<VulnerabilityReportDto> VulnerabilityReports { get; set; }
    }
}