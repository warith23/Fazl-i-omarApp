using Backend.Entities;
using Backend.Identity;
using Microsoft.EntityFrameworkCore;

namespace Backend.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Admin> Admins{get; set;}
        public DbSet<Level> Levels { get; set; }
        public DbSet<Result> Results{get; set;}
        public DbSet<Student> Students{get; set;}
        public DbSet<Subject> Subjects{get; set;}
        public DbSet<StudentSubject> StudentSubjects { get; set;}
        public DbSet<Teacher> Teachers{get; set;}
        public DbSet<TeacherSubject> TeacherSubjects{get; set;}
    }
}