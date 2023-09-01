using Microsoft.EntityFrameworkCore;

namespace KitapYazarApi.Model
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookTypeOfBook> BookTypeOfBooks { get; set; }
        public DbSet<TypeOfBook> TypeOfBooks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { Id = 1, UserName = "abc", Password = "123" });
        }

    }
}
