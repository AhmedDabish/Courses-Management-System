using D9_Lab.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace D9_Lab.DataLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=D9_LabDB;Integrated Security=True;TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "Ahmed",   Password = "1234", Track = "Backend",   ImagePath = "" },
                new User { Id = 2, UserName = "Sara",    Password = "5678", Track = "Frontend",  ImagePath = "" },
                new User { Id = 3, UserName = "Mohamed", Password = "abcd", Track = "FullStack", ImagePath = "" }
            );
        }
    }
}
