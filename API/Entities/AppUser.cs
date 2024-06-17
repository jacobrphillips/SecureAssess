namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }
    public string EmailAddress { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime LastActive { get; set; } = DateTime.UtcNow;
    public Photo Photo { get; set; }
    public List<Company> Companies { get; set; } = new List<Company>();
}
