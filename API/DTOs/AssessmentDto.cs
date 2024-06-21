using API.Entities;

namespace API.DTOs
{
    public class AssessmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public AssessmentType Type { get; set; }
        public AppUser Assessor { get; set; }
    }

    public enum AssessmentType
    {
        CyberEssentials,
        CyberEssentialsPlus
    }
}