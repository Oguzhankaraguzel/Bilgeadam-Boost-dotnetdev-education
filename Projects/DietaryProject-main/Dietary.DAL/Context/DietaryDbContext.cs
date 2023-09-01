using Dietary.DAL.SeedData;
using Dietary.Entities.Entities.EnumEntities;
using Dietary.Entities.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;

namespace Dietary.DAL.Context
{
    public class DietaryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealDetail> MealDetails { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<FoodTime> FoodTimes { get; set; }
        public DbSet<FoodFeature> FoodFeatures { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<ActivityLevel> ActivityLevels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=desktop-ff31an2\\sqlexpress;Database=DietaryDb;TrustServerCertificate=True;Integrated Security=True;");
        }
        // "Data Source=desktop-ff31an2\\sqlexpress;Database=DietaryDb;TrustServerCertificate=True;Integrated Security=True;"

        //"Server = LocalHost;Database=DietaryDb;TrustServerCertificate=True;Integrated Security=True;"
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDetail>().HasKey(ud => ud.UserId);
            modelBuilder.Entity<UserDetail>().HasIndex(ud => ud.DietId).IsUnique(false);
            modelBuilder.Entity<UserDetail>().HasIndex(ud => ud.GenderId).IsUnique(false);
            modelBuilder.Entity<UserDetail>().HasIndex(ud => ud.GoalId).IsUnique(false);
            modelBuilder.Entity<UserDetail>().HasIndex(ud => ud.ActivityLevelId).IsUnique(false);
            modelBuilder.Entity<MealDetail>().HasIndex(md => md.FoodId).IsUnique(false);
            modelBuilder.Entity<Meal>().HasIndex(m => m.FoodTimeId).IsUnique(false);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
            modelBuilder.Entity<User>().HasIndex(user => user.UserName).IsUnique();

            modelBuilder.Entity<FoodFeature>().HasKey(ff => new { ff.DietId, ff.FoodId, ff.FoodTypeId, ff.FoodTimeId });

            #region ForSeedData

            EnumTableSeedDatas ent = new();
            FoodSeedData fsd = new FoodSeedData();
            FoodFeaturesSeedData ffsd = new FoodFeaturesSeedData();
            AdminUser adu = new();
            DumyMealData dmd = new DumyMealData();
            ent.ETSeedData(modelBuilder);
            fsd.FSeedData(modelBuilder);
            ffsd.FFSeedData(modelBuilder);
            adu.AUSeedData(modelBuilder);
            dmd.DMDSeedData(modelBuilder);

            #endregion


        }


    }
}
