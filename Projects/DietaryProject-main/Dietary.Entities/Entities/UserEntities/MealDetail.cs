using Dietary.Entities.Entities.EnumEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.Entities.Entities.UserEntities
{
    public class MealDetail
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Meal))]
        public int MealId { get; set; }
        public Meal Meal { get; set; }
        [ForeignKey(nameof(Food))]
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public decimal Gram { get; set; }
    }
}
