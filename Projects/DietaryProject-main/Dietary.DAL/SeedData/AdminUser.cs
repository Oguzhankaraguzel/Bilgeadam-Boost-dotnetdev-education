using Azure;
using Dietary.Entities.Entities.EnumEntities;
using Dietary.Entities.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.DAL.SeedData
{
    internal class AdminUser // Erişim Düzeyi kesinlikle internal kalmalı. Başka katmanlardan çağırılmamalı
    {

        public void AUSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData
                (
                new User() { Id = 1, UserName = "Oguzhankrgzl", Email = "oguzhan.karaguzel@gmail.com", Password = sha256_hash("oguzhanKaraguzel!") },

                new User() { Id = 2, UserName = "Egezcn", Email = "zcn.ege@hotmail.com", Password = sha256_hash("egeOzcan!") },

                new User() { Id = 3, UserName = "Aykuttrz", Email = "aykut.terzi@gmail.com", Password = sha256_hash("aykutTerzi!") },

                new User() { Id = 4, UserName = "Alizn", Email = "ali.ozan@gmail.com", Password = sha256_hash("aliOzan!") }
                );

            modelBuilder.Entity<UserDetail>()
                .HasData
                (
                new UserDetail() { UserId = 1, FirstName = "Oğuzhan", LastName = "Karagüzel", BirthDate = Convert.ToDateTime("1994-04-30"), Weigth = 75, Height = 178, ActivityLevelId = 1, DietId = 3, GoalId = 3, GenderId = 2, PhotoPath = ".\\CatPhoto" },

                new UserDetail() { UserId = 2, FirstName = "Ege", LastName = "Özcan", BirthDate = Convert.ToDateTime("1996-08-22"), Weigth = 60, Height = 179, ActivityLevelId = 4, DietId = 1, GoalId = 1, GenderId = 2, PhotoPath = ".\\CatPhoto" },

                new UserDetail() { UserId = 3, FirstName = "Aykut", LastName = "Terzi", BirthDate = Convert.ToDateTime("1988-07-08"), Weigth = 90, Height = 174, ActivityLevelId = 3, DietId = 2, GoalId = 2, GenderId = 2, PhotoPath = ".\\CatPhoto" },

                new UserDetail() { UserId = 4, FirstName = "Ali Ozan", LastName = "Özkul", BirthDate = Convert.ToDateTime("1996-01-12"), Weigth = 88, Height = 188, ActivityLevelId = 2, DietId = 3, GoalId = 3, GenderId = 2, PhotoPath = ".\\CatPhoto" }
                );
        }

        /// <summary>
        /// Kullanıcının girdiği parolayı şifreler
        /// </summary>
        /// <param name = "password" > Girilen henhangi bir şifre</param>
        /// <returns>şifrelenmiş parolayı geri döndürür</returns>
        public string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            { return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2"))); }
        }

       
    }
}
