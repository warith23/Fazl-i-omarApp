using Backend.Contract;

namespace Backend.Identity
{
    public class UserRole : AuditableEntity
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        public Role Role { get; set; }
        public Guid RoleId { get; set; }
    }
}