using Backend.Contract;

namespace Backend.Identity
{
   public class Role : AuditableEntity
    {
        public string Name { get; set; }
        public List<UserRole> UserRole { get; set; } = new List<UserRole>();
    }
}