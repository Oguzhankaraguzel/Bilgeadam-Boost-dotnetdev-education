using _10.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _10.Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

 
        public virtual DbSet<Category> Categories { get; set; }
        //Fluent API
        //application programming interface
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().Property(cat => cat.Id).HasColumnName("CategoryId");

            base.OnModelCreating(builder);
        }
    }
}