using Dietary.Entities.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.DAL.SeedData
{
    internal class DumyMealData
    {
        public void DMDSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meal>()
                .HasData
                (
                new Meal() { Id = 1, UserDetailId = 1, FoodTimeId = 1, MealTime = Convert.ToDateTime("2023-03-25") },
                new Meal() { Id = 2, UserDetailId = 1, FoodTimeId = 2, MealTime = Convert.ToDateTime("2023-03-26") },
                new Meal() { Id = 3, UserDetailId = 1, FoodTimeId = 4, MealTime = Convert.ToDateTime("2023-03-27") },
                new Meal() { Id = 4, UserDetailId = 1, FoodTimeId = 4, MealTime = Convert.ToDateTime("2023-03-30") },
                new Meal() { Id = 5, UserDetailId = 2, FoodTimeId = 4, MealTime = Convert.ToDateTime("2023-03-12") },
                new Meal() { Id = 6, UserDetailId = 2, FoodTimeId = 4, MealTime = Convert.ToDateTime("2023-03-14") },
                new Meal() { Id = 7, UserDetailId = 2, FoodTimeId = 3, MealTime = Convert.ToDateTime("2023-03-21") },
                new Meal() { Id = 8, UserDetailId = 2, FoodTimeId = 1, MealTime = Convert.ToDateTime("2023-03-28") },
                new Meal() { Id = 9, UserDetailId = 3, FoodTimeId = 4, MealTime = Convert.ToDateTime("2023-02-21") },
                new Meal() { Id = 10, UserDetailId = 3, FoodTimeId = 2, MealTime = Convert.ToDateTime("2023-02-28") },
                new Meal() { Id = 11, UserDetailId = 4, FoodTimeId = 1, MealTime = Convert.ToDateTime("2023-02-25") },
                new Meal() { Id = 12, UserDetailId = 4, FoodTimeId = 2, MealTime = Convert.ToDateTime("2023-02-25") },
                new Meal() { Id = 13, UserDetailId = 4, FoodTimeId = 3, MealTime = Convert.ToDateTime("2023-02-28") },
                new Meal() { Id = 14, UserDetailId = 4, FoodTimeId = 4, MealTime = Convert.ToDateTime("2023-02-28") }
                );

            modelBuilder.Entity<MealDetail>().HasData
                (
                new MealDetail() { Id = 1, MealId = 1, FoodId = 51, Gram = 100 },
                new MealDetail() { Id = 2, MealId = 1, FoodId = 72, Gram = 20 },
                new MealDetail() { Id = 3, MealId = 1, FoodId = 81, Gram = 100 },
                new MealDetail() { Id = 4, MealId = 1, FoodId = 90, Gram = 100 },
                new MealDetail() { Id = 5, MealId = 2, FoodId = 51, Gram = 100 },
                new MealDetail() { Id = 6, MealId = 2, FoodId = 99, Gram = 150 },
                new MealDetail() { Id = 7, MealId = 2, FoodId = 85, Gram = 100 },
                new MealDetail() { Id = 8, MealId = 2, FoodId = 100, Gram = 50 },
                new MealDetail() { Id = 9, MealId = 3, FoodId = 105, Gram = 50 },
                new MealDetail() { Id = 10, MealId = 3, FoodId = 1, Gram = 150 },
                new MealDetail() { Id = 11, MealId = 3, FoodId = 22, Gram = 100 },
                new MealDetail() { Id = 12, MealId = 3, FoodId = 50, Gram = 50 },
                new MealDetail() { Id = 13, MealId = 4, FoodId = 88, Gram = 100 },
                new MealDetail() { Id = 14, MealId = 5, FoodId = 86, Gram = 100 },
                new MealDetail() { Id = 15, MealId = 6, FoodId = 95, Gram = 120 },
                new MealDetail() { Id = 16, MealId = 7, FoodId = 5, Gram = 150 },
                new MealDetail() { Id = 17, MealId = 7, FoodId = 51, Gram = 100 },
                new MealDetail() { Id = 18, MealId = 7, FoodId = 109, Gram = 70 },
                new MealDetail() { Id = 19, MealId = 8, FoodId = 110, Gram = 112 },
                new MealDetail() { Id = 20, MealId = 8, FoodId = 76, Gram = 150 },
                new MealDetail() { Id = 21, MealId = 9, FoodId = 64, Gram = 150 },
                new MealDetail() { Id = 22, MealId = 9, FoodId = 80, Gram = 85 },
                new MealDetail() { Id = 23, MealId = 10, FoodId = 82, Gram = 100 },
                new MealDetail() { Id = 24, MealId = 10, FoodId = 52, Gram = 150 },
                new MealDetail() { Id = 25, MealId = 10, FoodId = 13, Gram = 150 },
                new MealDetail() { Id = 26, MealId = 10, FoodId = 93, Gram = 200 },
                new MealDetail() { Id = 27, MealId = 11, FoodId = 84, Gram = 100 },
                new MealDetail() { Id = 28, MealId = 11, FoodId = 71, Gram = 80 },
                new MealDetail() { Id = 29, MealId = 11, FoodId = 54, Gram = 187 },
                new MealDetail() { Id = 30, MealId = 12, FoodId = 117, Gram = 50 },
                new MealDetail() { Id = 31, MealId = 12, FoodId = 104, Gram = 200 },
                new MealDetail() { Id = 32, MealId = 12, FoodId = 53, Gram = 250 },
                new MealDetail() { Id = 33, MealId = 13, FoodId = 3, Gram = 137 },
                new MealDetail() { Id = 34, MealId = 13, FoodId = 10, Gram = 156 },
                new MealDetail() { Id = 35, MealId = 13, FoodId = 99, Gram = 191 },
                new MealDetail() { Id = 36, MealId = 14, FoodId = 74, Gram = 200 },
                new MealDetail() { Id = 37, MealId = 14, FoodId = 59, Gram = 200 }
                );
        }
    }
}
