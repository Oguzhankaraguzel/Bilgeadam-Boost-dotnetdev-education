using Microsoft.EntityFrameworkCore;

namespace GrupMvc.Models
{
    public class MagzaContext : DbContext
    {
        public MagzaContext(DbContextOptions<MagzaContext> options) : base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Catogory> Catogories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Catogory>().HasData(new Catogory { Id = 1, Name = "Elektronik" }, new Catogory { Id = 2, Name = "Ev Aletleri" });
        //    modelBuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Bilgisayar", InStoct = true, Price = 15000, CatogoryId = 1 }, new Product { Id = 2, Name = "Tablet", InStoct = true, Price = 11000, CatogoryId = 1 }, new Product { Id = 3, Name = "Mikser", InStoct = false, Price = 500, CatogoryId = 2 });
        //}




    }
}
