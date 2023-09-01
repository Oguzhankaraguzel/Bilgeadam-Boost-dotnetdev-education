using Dietary.Entities.Abstract;
using Dietary.Entities.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.Entities.Entities.EnumEntities
{
    public class FoodTime : EnumTable
    {
        public Meal Meal { get; set; }
        public ICollection<FoodFeature> FoodFeatures { get; set; }

    }
}
