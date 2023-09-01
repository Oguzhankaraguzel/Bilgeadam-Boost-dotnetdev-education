using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDb.Class
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumName { get; set; }
        public string SingerName { get; set; }
        public DateTime RelaseDate { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public bool SaleContinue { get; set; }
        public Artist Artist { get; set; }
    }
}
