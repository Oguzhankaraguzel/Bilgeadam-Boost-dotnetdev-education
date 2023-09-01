using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.Entities.Entities.EnumEntities
{
    public class FoodFeature
    {
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int DietId { get; set; }
        public Diet Diet { get; set; }
        public int FoodTypeId { get; set; }
        public FoodType FoodType { get; set; }
        public int FoodTimeId { get; set; }
        public FoodTime FoodTime { get; set; }

    }
}
