using Backend.Contract;

namespace Backend.Entities
{
    public class Level : AuditableEntity
    {
        public string LevelName { get; set; }
        public IList<Student> Students { get; set;}
    }
}
