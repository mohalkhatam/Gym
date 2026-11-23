using Microsoft.EntityFrameworkCore;
using Gym.Entities;
using System.Reflection;
namespace Gym.Context
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Gym;Trusted_Connection=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<MemberShip> MemberShip { get; set; }

    }
    
}
