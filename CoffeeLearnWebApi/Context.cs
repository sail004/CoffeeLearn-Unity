using Microsoft.EntityFrameworkCore;
using CoffeeLearnWebApi.Models;


namespace CoffeeLearnWebApi
{
    public class CoffeeLearnDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Documents> Documents { get; set; } = null!;

        public DbSet<Role> Roles { get; set; } = null!;

        public DbSet<Training> Trainings { get; set; } = null!;

        public DbSet<UserTrainingDone> UserTrainingsDone { get; set; } = null!;

        public DbSet<DocumentResourses> DocumentResourses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=1234");
        }
    }
}