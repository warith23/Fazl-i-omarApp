using Backend.Contract;
using Backend.Identity;

namespace Backend.Entities
{
    public class Admin:AuditableEntity
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Email { get;set;}
        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}