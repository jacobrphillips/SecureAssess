using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Assessment> Assessments { get; set; }
    public DbSet<Questionnaire> Questionnaires { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Photo> Photos { get; set; }
    public DbSet<AnswerOption> AnswerOptions { get; set; }
    public DbSet<VulnerabilityReport> VulnerabilityReports { get; set; }
    public DbSet<Sample> Samples { get; set; }
}
