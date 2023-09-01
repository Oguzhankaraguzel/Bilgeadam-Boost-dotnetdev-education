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
    public class FoodService
    {
        DietaryDbContext _db = new DietaryDbContext();

        /// <summary>
        /// Kullanıcının diyet türüne ve seçilen yiyecek türüne göre yemekleri listeler
        /// </summary>
        /// <param name="userDetail"></param>
        /// <param name="FoodType"></param>
        /// <returns>listeyi geri döndürür</returns>
        public  List<Food> GetFoodByType(UserDetail userDetail, int FoodType)
        {
            return  _db.Foods
    .Where(f => f.FoodFeatures.Any(ff => ff.DietId <= userDetail.DietId && ff.FoodTypeId == FoodType))
    .ToList();
        }

        /// <summary>
        /// Kullanıcının diyeti türüne göre yemekleri listeler
        /// </summary>
        /// <param name="userDetail"></param>
        /// <returns>Listeyi geri döndürür</returns>
        public List<Food> GetTableFood(UserDetail userDetail)
        {
            if (userDetail.DietId == 3)
            {
                var res = _db.UserDetails.Join(_db.Diets, x => x.DietId, y => y.Id, (x, y) => new { Userdetails = x, Diet = y }).Join(_db.FoodFeatures, xy => xy.Diet.Id, z => z.DietId, (xy, z) => new { userDetailDiet = xy, FoodFeature = z }).Join(_db.Foods, xyz => xyz.FoodFeature.FoodId, c => c.Id, (xyz, c) => new { ortakTablo = xyz, FoodTablosu = c }).Where(x =>  x.ortakTablo.FoodFeature.FoodId == x.FoodTablosu.Id).Select(x => x.FoodTablosu).ToList();
                return res;
            }

            else if (userDetail.DietId == 2)
            {
                var res = _db.UserDetails.Join(_db.Diets, x => x.DietId, y => y.Id, (x, y) => new { Userdetails = x, Diet = y }).Join(_db.FoodFeatures, xy => xy.Diet.Id, z => z.DietId, (xy, z) => new { userDetailDiet = xy, FoodFeature = z }).Join(_db.Foods, xyz => xyz.FoodFeature.FoodId, c => c.Id, (xyz, c) => new { ortakTablo = xyz, FoodTablosu = c }).Where(x => x.ortakTablo.FoodFeature.DietId != 3 && x.ortakTablo.FoodFeature.FoodId == x.FoodTablosu.Id).Select(x => x.FoodTablosu).ToList();
                return res;
            }

            else
            {
                var res = _db.UserDetails.Join(_db.Diets, x => x.DietId, y => y.Id, (x, y) => new { Userdetails = x, Diet = y }).Join(_db.FoodFeatures, xy => xy.Diet.Id, z => z.DietId, (xy, z) => new { userDetailDiet = xy, FoodFeature = z }).Join(_db.Foods, xyz => xyz.FoodFeature.FoodId, c => c.Id, (xyz, c) => new { ortakTablo = xyz, FoodTablosu = c }).Where(x => x.ortakTablo.FoodFeature.DietId == userDetail.DietId && x.ortakTablo.FoodFeature.FoodId == x.FoodTablosu.Id).Select(x => x.FoodTablosu).ToList();
                return res;
            }

        }


        /// <summary>
        /// sisteme yeni bir yemek ekler
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="caloriePerGram"></param>
        /// <param name="photoPath"></param>
        /// <param name="dietId"></param>
        /// <param name="foodTypeId"></param>
        /// <param name="foodTimeId"></param>
        /// <exception cref="InvalidFoodException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public void AddFood(string foodName, decimal caloriePerGram,string? photoPath,int dietId,List<int> foodTypeId, List<int> foodTimeId) 
        {
            if (string.IsNullOrEmpty(foodName)) throw new InvalidFoodException("There should be a food name");

            if (foodTypeId.Count == 0) throw new ArgumentException("There should be a type of food");

            if (foodTimeId.Count == 0) throw new ArgumentException("A meal should belong to a food time");

            Food food = new Food()
            {
                Name = foodName,
                CaloryPerGram = caloriePerGram,
                PhotoPath = photoPath,
            };

            _db.Foods.Add(food);
            _db.SaveChanges();
            food = _db.Foods.FirstOrDefault(f => f.Name == foodName);

            foreach (int ftid in foodTypeId)
            {
                foreach (int item in foodTimeId)
                {
                    FoodFeature ff = new FoodFeature()
                    {
                        FoodId = food.Id,
                        DietId = dietId,
                        FoodTimeId = item,
                        FoodTypeId = ftid
                    };

                    _db.FoodFeatures.Add(ff);
                    _db.SaveChanges();
                }
            }

        }

        /// <summary>
        /// Yemeği veri tabanından siler
        /// </summary>
        /// <param name="foodName"></param>
        /// <exception cref="NullReferenceException"></exception>
        public void DeleteFood(string foodName) 
        {
            Food food = _db.Foods.FirstOrDefault(x => x.Name == foodName);
            if (food == null) throw new NullReferenceException();
            _db.Foods.Remove(food);
            _db.SaveChanges();
        }

        /// <summary>
        /// Yemeklerin isimlerini döndürür.
        /// </summary>
        /// <returns></returns>
        public ICollection GetFoodName() 
        {
            return _db.Foods.Select(x => x.Name).ToList();
        }
    }

}
