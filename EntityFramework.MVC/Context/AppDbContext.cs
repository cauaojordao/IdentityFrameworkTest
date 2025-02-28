using EntityFramework.MVC.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.MVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<AppFile> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User { 
                    Id = 1,
                    Name = "admin", 
                    Email = "admin@admin.com" 
                });
        }
    }
}
