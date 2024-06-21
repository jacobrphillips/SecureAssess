using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Assessments")]
    public class Assessment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public AssessmentType Type { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public AppUser Assessor { get; set; }
        public List<AssessmentStatus> Statuses { get; set; } = new List<AssessmentStatus>();
        public List<Questionnaire> Questionnaires { get; set; } = new List<Questionnaire>();
        public List<VulnerabilityReport> VulnerabilityReports { get; set; } = new List<VulnerabilityReport>();
    }

    public enum AssessmentType
    {
        CyberEssentials,
        CyberEssentialsPlus
    }

}