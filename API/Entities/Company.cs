using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Companies")]
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<AppUser> Contacts { get; set; } = new List<AppUser>();
        public List<Assessment> Assessments { get; set; } = new List<Assessment>();
        public List<VulnerabilityReport> VulnerabilityReports { get; set; } = new List<VulnerabilityReport>();
    }
}