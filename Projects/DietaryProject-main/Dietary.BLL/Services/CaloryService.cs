using Dietary.DAL.Context;
using Dietary.Entities.Entities.UserEntities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.BLL.Services
{
    public class CaloryService
    {
        DietaryDbContext _db = new DietaryDbContext();

       
       

        

        /// <summary>
        /// Kullanıcının bugün aldığı toplam kalori.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>değeri decimal olarak döndürür</returns>
        public decimal UserTakenCaloryDaily(User user)
        {
            var list = _db.Meals.Where(m => m.UserDetailId == user.Id && m.MealTime == DateTime.Today);
            return list.Sum(m => m.CaloriesTaken);
        }

        /// <summary>
        /// Kullanıcının haftalık aldığı kalori ortalaması
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public decimal UserTakenCaloryWeeklyAvg(User user)
        {
            List<decimal> average = new List<decimal>();
            for (int i = 0; i < 7; i++) 
            {
                var list = _db.Meals.Where(m => m.UserDetailId == user.Id && m.MealTime == DateTime.Today.AddDays(-i));
                average.Add(list.Sum(m => m.CaloriesTaken));
            }
            return average.Average();
        }

        /// <summary>
        /// Kullanıcının aylık aldığı kalori ortalaması
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public decimal UserTakenMonthlyAvg(User user)
        {
            List<decimal> average = new List<decimal>();
            for (int i = 0; i < 30; i++)
            {
                var list = _db.Meals.Where(m => m.UserDetailId == user.Id && m.MealTime == DateTime.Today.AddDays(-i));
                average.Add(list.Sum(m => m.CaloriesTaken));
            }
            return average.Average();
        }
    }
}
