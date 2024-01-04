using Backend.Context;
using Backend.Entities;
using Backend.Interface.Repositories;

namespace Backend.Implementation.Repositories
{
    public class LevelRepository : BaseRepository<Level>, ILevelRepository
    {
        public LevelRepository(ApplicationContext context) 
        {
            _context = context;
        }
    }
}
