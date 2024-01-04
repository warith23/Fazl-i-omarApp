using Backend.Context;
using Backend.Entities;
using Backend.Interface.Repositories;

namespace Backend.Implementation.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationContext context) 
        {
            _context = context;
        }
    }
}
