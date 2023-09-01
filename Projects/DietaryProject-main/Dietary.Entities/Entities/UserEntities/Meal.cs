using Dietary.Entities.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.Entities.Entities.UserEntities
{
    public class Meal
    {
        public int Id { get; set; }
        public int UserDetailId { get; set; }
        public int FoodTimeId { get; set; }
        public UserDetail UserDetail { get; set; }
        public FoodTime FoodTime { get; set; }
        public DateTime MealTime { get; set; } = DateTime.Now;
        public ICollection<MealDetail> MealDetails { get; set; }
        public decimal CaloriesTaken { get; set; } = 0;
    }
}
