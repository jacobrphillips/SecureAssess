namespace API.Entities
{
    public class AppRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<AppUserRole> UserRoles { get; set; }
    }
}