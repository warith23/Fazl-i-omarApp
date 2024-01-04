using Backend.Context;
using Backend.Identity;
using Backend.Interface.Repositories;

namespace Backend.Implementation.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) 
        {
            _context = context;
        }
    }
}
