using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Models;

namespace Cinema.Models
{
    public class Film : Bclass
    {
        public DateTime ReleaseDate { get; set; }
        public ICollection<FilmCategory> Categories { get; set; }
    }
}
