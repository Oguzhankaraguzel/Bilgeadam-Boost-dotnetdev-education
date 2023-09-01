using Dietary.BLL.Exceptions;
using Dietary.DAL.Context;
using Dietary.Entities.Entities.EnumEntities;
using Dietary.Entities.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.BLL.Services
{
    public class MealService
    {
        DietaryDbContext _db = new DietaryDbContext();
        Meal _ml;
        MealDetail _md;

        /// <summary>
        /// Database de kayıtlı olan meal sayısını tutar
        /// </summary>
        /// <returns></returns>
        public int CountMeals()
        {
            var mealsList = _db.Meals.ToList();
            int count = mealsList.Count;

            return count;
        }

       
        /// <summary>
        /// Kullanıcıya yeni bir öğün ekler.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="FoodTimeId"></param>
        /// <param name="MealTime"></param>
        /// <returns>mealId'yi geri döndürür</returns>
        /// <exception cref="FoodTimeException"></exception>
        public int AddMeal(User user, int FoodTimeId, DateTime MealTime)
        {
            try
            {
                _ml = new Meal();
                _ml.UserDetailId = user.Id;
                _ml.FoodTimeId = FoodTimeId;
                _ml.MealTime = MealTime;
                _db.Meals.Add(_ml);
                _db.SaveChanges();
                return _ml.Id;
            }
            catch (Exception)
            {
                throw new FoodTimeException("Please enter a valid meal time");
            }
        }

        /// <summary>
        /// Kullanıcının öğününe yemek ekler.
        /// </summary>
        /// <param name="FoodName"></param>
        /// <param name="gram"></param>
        /// <exception cref="InvalidFoodException"></exception>
        /// <exception cref="InvalidFoodGramException"></exception>
        public void AddFoodToMeal(int mealId, string FoodName, decimal gram)
        {

            try
            {
                Food food = _db.Foods.Where(f => f.Name == FoodName).First();
                if (food == null)
                {
                    throw new InvalidFoodException();
                }
                if (gram == 0 || gram <= 0)
                {
                    throw new InvalidFoodGramException();
                }
                _md = new MealDetail();
                _md.MealId = mealId;
                _md.FoodId = food.Id;
                _md.Gram = gram;
                _ml.CaloriesTaken += gram * food.CaloryPerGram;
                _db.MealDetails.Add(_md);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Kullanıcının seçmiş oluğu yemeği öğününden siler.
        /// </summary>
        /// <param name="mealId"></param>
        /// <param name="FoodName"></param>
        /// <param name="gram"></param>
        public void DeleteFoodToMeal(int mealId, string FoodName, decimal gram) 
        {
            try
            {
                Food food = _db.Foods.Where(f => f.Name == FoodName).First();
                _ml = _db.Meals.Where(ml => ml.Id == mealId).First();
                if (food == null)
                {
                    throw new InvalidFoodException();
                }
                if (gram == 0 || gram <= 0)
                {
                    throw new InvalidFoodGramException();
                }
                _md = new MealDetail();
                _md = _db.MealDetails.Where(md => md.MealId == mealId && md.FoodId == food.Id && md.Gram == gram).First();
                _ml.CaloriesTaken -= gram * food.CaloryPerGram;
                _db.MealDetails.Remove(_md);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Seçilen öğünün kalorisini getirir.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public decimal GetMealCalorie(int mealId) 
        {
            try
            {
                return _db.Meals.Where(ml => ml.Id == mealId).FirstOrDefault().CaloriesTaken;
            }
            catch (Exception)
            {

                throw new ArgumentException("There is no meal");
            }
        }

        /// <summary>
        /// Öğüne eklenmiş yemeklerin Sadece adını ve gramını listeler
        /// </summary>
        /// <returns>liste olarak geri döndürür</returns>
        public ICollection AddingFoodList(int mealId)
        {
            return _db.MealDetails
                .Where(md => md.MealId == mealId)
                .Include(md => md.Food)
                .Select(md => new { md.Food.Name, md.Gram }).ToList();
        }

        /// <summary>
        /// Öğüne eklenmiş yemekleri kontrol eder.
        /// </summary>
        /// <param name="FoodName"></param>
        /// <returns>Eğer yemek listede varsa false, yoksa true döner</returns>
        public bool CheckAddingFood(string FoodName)
        {
            MealDetail _checkfood;
            _checkfood = _db.MealDetails
                .Include(md => md.Food)
                .Where(md => md.MealId == _ml.Id && md.Food.Name == FoodName).First();
            if (_checkfood == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Kullanıcının öğününü siler
        /// </summary>
        /// <param name="mealId"></param>
        public void DeleteMeal(int mealId)
        {
            try
            {
                _ml = _db.Meals.Where(ml => ml.Id == mealId).FirstOrDefault();
                DeleteAllMealDetail(mealId);
                _db.Meals.Remove(_ml);
                _db.SaveChanges();
            }
            catch
            {
                throw new InvalidMealException();
            }
        }

        /// <summary>
        /// İlgili öğündeki tüm yemekleri siler
        /// </summary>
        /// <param name="mealId"></param>
        public void DeleteAllMealDetail(int mealId)
        {
            try
            {
                _ml = _db.Meals.Where(ml => ml.Id == mealId).FirstOrDefault();
                List<MealDetail> _md = _db.MealDetails.Where(md => md.MealId == mealId).ToList();
                _db.MealDetails.RemoveRange(_md);
                _ml.CaloriesTaken = 0;
                _db.SaveChanges();
            }
            catch
            {
                throw new InvalidMealException();
            }
        }

        public int FindMealId(string datetime, string foodtime, decimal calori) 
        {
            try
            {
                FoodTime ft = _db.FoodTimes.Where(ft => ft.Name == foodtime).FirstOrDefault();
                _ml =
                    _db.Meals
                    .Where(ml => ml.MealTime == Convert.ToDateTime(datetime) && ml.FoodTimeId == ft.Id && ml.CaloriesTaken == calori).FirstOrDefault();
                return _ml.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
