using Microsoft.EntityFrameworkCore;
using CoffeeLearnWebApi.Models;


namespace CoffeeLearnWebApi
{
    public class CoffeeLearnDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Documents> Documents { get; set; } = null!;

        public DbSet<Role> Roles { get; set; } = null!;

        public DbSet<Courses> Courses { get; set; } = null!;

        public DbSet<Progress> Progress { get; set; } = null!;

        public DbSet<CourseStructure> CourseStructures { get; set; } = null!;

        public DbSet<Lecture> Lecture { get; set; }
        public DbSet<PracticeTest> practiceTests { get; set; } = null!;

        public DbSet<DocumentResourses> DocumentResourses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=1234");
        }
    }
}