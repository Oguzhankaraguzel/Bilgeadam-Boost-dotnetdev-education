using Dietary.Entities.Abstract;
using Dietary.Entities.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.Entities.Entities.EnumEntities
{
    public class FoodType  : EnumTable
    {
        public ICollection<FoodFeature> FoodFeatures { get; set; }
    }
}
