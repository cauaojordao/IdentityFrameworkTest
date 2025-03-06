using CleanIdentity.Domain.Entities;
using CleanIdentity.Persistence.Services.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanIdentity.Persistence.Context
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AppFile> AppFiles { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answear> Answears { get; set; }
    }
}
