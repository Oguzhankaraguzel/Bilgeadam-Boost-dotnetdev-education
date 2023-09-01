using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApiCRUD.Model
{
    public partial class YazarKitapDbContext : DbContext
    {
        public YazarKitapDbContext()
        {
        }

        public YazarKitapDbContext(DbContextOptions<YazarKitapDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kitap> Kitaps { get; set; } = null!;
        public virtual DbSet<Tur> Turs { get; set; } = null!;
        public virtual DbSet<Yazar> Yazars { get; set; } = null!;
        public virtual DbSet<KitapTur> KitapTurs { get; set; } = null!;

        public virtual DbSet<User> Users { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        

            modelBuilder.Entity<Tur>().HasData(new Tur { Id = 1, TurAd = "Macera"});
            modelBuilder.Entity<Tur>().HasData(new Tur { Id = 2, TurAd = "Roman" });
            modelBuilder.Entity<Tur>().HasData(new Tur { Id = 3, TurAd = "BilimKurgu" });
            modelBuilder.Entity<Tur>().HasData(new Tur { Id = 4, TurAd = "Gizem" });
            modelBuilder.Entity<Tur>().HasData(new Tur { Id = 5, TurAd = "Biyografi" });
            modelBuilder.Entity<Tur>().HasData(new Tur { Id = 6, TurAd = "Felsefe" });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
