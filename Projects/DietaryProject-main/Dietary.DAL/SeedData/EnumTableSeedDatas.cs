using Dietary.Entities.Entities.EnumEntities;
using Dietary.Entities.Entities.UserEntities;
using Dietary.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.DAL.SeedData
{
    internal class EnumTableSeedDatas
    {
        public void ETSeedData(ModelBuilder modelBuilder)
        {
            foreach (var item in Enum.GetValues(typeof(ActivityLevelEnum)))
            {
                modelBuilder.Entity<ActivityLevel>().HasData
                (
                new ActivityLevel() { Id = (int)item, Name = item.ToString() }
                ); 
            }

            foreach (var item in Enum.GetValues(typeof(DietEnum)))
            {
                modelBuilder.Entity<Diet>().HasData
                (
                new Diet { Id = (int)item, Name = item.ToString() }
                );
            }

            foreach (var item in Enum.GetValues(typeof(GenderEnum)))
            {
                modelBuilder.Entity<Gender>().HasData
                (
                new Gender { Id = (int)item, Name = item.ToString() }
                );
            }

            foreach (var item in Enum.GetValues(typeof(GoalEnum)))
            {
                modelBuilder.Entity<Goal>().HasData
                (
                new Goal { Id = (int)item, Name = item.ToString() }
                );
            }

            foreach (var item in Enum.GetValues(typeof(FoodTimeEnum)))
            {
                modelBuilder.Entity<FoodTime>().HasData
                (
                new FoodTime { Id = (int)item, Name = item.ToString() }
                );
            }

            foreach (var item in Enum.GetValues(typeof(FoodTypeEnum)))
            {
                modelBuilder.Entity<FoodType>().HasData
                (
                new FoodType { Id = (int)item, Name = item.ToString() }
                );
            }

            
        }
    }
}
