using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace Cinema.Models
{
    
    public class CinemaDbContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=desktop-ff31an2\\sqlexpress;Database=CinemaDb;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmCategory>()
                .HasKey(fc => new { fc.FilmId, fc.CategoryId });

            modelBuilder.Entity<Film>()
                .HasData
                (
                new Film { Id = 1, Name = "Pirates of the Caribbean: The Curse of the Black Pearl", ReleaseDate = Convert.ToDateTime("2003-01-01") },
                new Film { Id = 2, Name = "The Matrix", ReleaseDate = Convert.ToDateTime("2003-01-01") }, 
                new Film { Id = 3, Name = "The Godfather", ReleaseDate = Convert.ToDateTime("1972-01-01") },
                new Film { Id = 4, Name = "Yes Man", ReleaseDate = Convert.ToDateTime("2008-01-01") },
                new Film { Id = 5, Name = "Deadpool", ReleaseDate = Convert.ToDateTime("2016-01-01") },
                new Film { Id = 6, Name = "Pride & Prejudice", ReleaseDate = Convert.ToDateTime("2008-01-01") }
                );

            modelBuilder.Entity<Category>().HasData
                (
                new Category { Id = 1, Name = "Aksiyon", Popularity = 10 },
                new Category { Id = 2, Name = "Macera", Popularity = 8 },
                new Category { Id = 3, Name = "Fantastik", Popularity = 9 },
                new Category { Id = 4, Name = "Bilim Kurgu", Popularity = 10 },
                new Category { Id = 5, Name = "Suç", Popularity = 5 },
                new Category { Id = 6, Name = "Drama", Popularity = 6 },
                new Category { Id = 7, Name = "Komedi", Popularity = 10 },
                new Category { Id = 8, Name = "Romantik", Popularity = 4 }
                );

            modelBuilder.Entity<FilmCategory>().HasData
                (
                new FilmCategory { FilmId = 1, CategoryId = 1 },
                new FilmCategory { FilmId = 1, CategoryId = 2 },
                new FilmCategory { FilmId = 1, CategoryId = 3 },
                new FilmCategory { FilmId = 2, CategoryId = 1 },
                new FilmCategory { FilmId = 2, CategoryId = 2 },
                new FilmCategory { FilmId = 2, CategoryId = 4 },
                new FilmCategory { FilmId = 3, CategoryId = 1 },
                new FilmCategory { FilmId = 3, CategoryId = 5 },
                new FilmCategory { FilmId = 3, CategoryId = 6 },
                new FilmCategory { FilmId = 4, CategoryId = 3 },
                new FilmCategory { FilmId = 4, CategoryId = 7 },
                new FilmCategory { FilmId = 5, CategoryId = 1 },
                new FilmCategory { FilmId = 5, CategoryId = 3 },
                new FilmCategory { FilmId = 5, CategoryId = 7 },
                new FilmCategory { FilmId = 6, CategoryId = 6 },
                new FilmCategory { FilmId = 6, CategoryId = 8 }
                );

        }
    }

    
}
