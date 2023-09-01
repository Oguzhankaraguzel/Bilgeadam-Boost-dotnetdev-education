using Dietary.Entities.Abstract;
using Dietary.Entities.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.Entities.Entities.EnumEntities
{
    public class Food : EnumTable
    {
        public decimal CaloryPerGram { get; set; }
        public string? PhotoPath { get; set; }
        public byte[]? Photo { get; set; }
        public MealDetail MealDetail { get; set; }
        public ICollection<FoodFeature> FoodFeatures { get; set; }

    }
}
