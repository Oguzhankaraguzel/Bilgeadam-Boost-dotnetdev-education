using System;
using System.Collections.Generic;

namespace WebApiCRUD.Model
{
    public partial class Tur
    {
        public Tur()
        {
            Kitaps = new HashSet<KitapTur>();
        }

        public int Id { get; set; }
        public string TurAd { get; set; } = null!;
        public virtual ICollection<KitapTur> Kitaps { get; set; } 
    }
}
