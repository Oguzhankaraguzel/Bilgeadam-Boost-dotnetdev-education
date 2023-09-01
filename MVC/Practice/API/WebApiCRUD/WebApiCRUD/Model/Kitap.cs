using System;
using System.Collections.Generic;

namespace WebApiCRUD.Model
{
    public partial class Kitap
    {
        public Kitap()
        {
            Turs = new HashSet<KitapTur>();
        }

        public int Id { get; set; }
        public string KitapAd { get; set; } = null!;
        public int SayfaSayisi { get; set; }
        public int YazarId { get; set; }

        public virtual Yazar? Yazar { get; set; } = null!;

        public virtual ICollection<KitapTur> Turs { get; set; }
    }
}
