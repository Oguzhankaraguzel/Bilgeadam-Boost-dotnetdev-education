using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restoranmenu.Siniflar
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public decimal BuyukBoyFiyati { get; set; }
        public decimal OrtaBoyFiyati { get; set; }
        public decimal KucukBoyFiyati { get; set; }
        public Image UrunFotografi { get; set; }
    }
}
