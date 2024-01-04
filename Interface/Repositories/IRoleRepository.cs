using Backend.Identity;

namespace Backend.Interface.Repositories
{
    public interface IRoleRepository : IBaseRepository<Role>
    {
        Task<IList<Role>> GetRolesByUserId(Guid id);
    }
}
