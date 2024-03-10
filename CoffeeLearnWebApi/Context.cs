using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AuthExample2.Models;
using CoffeeLearnWebApi.Models;


namespace AuthExample2
{ 
public class AuthExampleContext : DbContext
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