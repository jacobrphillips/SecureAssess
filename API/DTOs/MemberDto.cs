namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public PhotoDto Photo { get; set; }
        public List<CompanyDto> Companies { get; set; }
    }
}