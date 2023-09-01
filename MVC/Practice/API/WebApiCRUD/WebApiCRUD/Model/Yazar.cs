using System;
using System.Collections.Generic;

namespace WebApiCRUD.Model
{
    public partial class Yazar
    {
        public Yazar()
        {
            Kitaps = new HashSet<Kitap>();
        }

        public int Id { get; set; }
        public string YazarAdi { get; set; } = null!;
        public string YazarSoyAd { get; set; } = null!;

        public virtual ICollection<Kitap> Kitaps { get; set; }
    }
}
