using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Models;

namespace Cinema.Models
{
    public class Category : Bclass
    {
    
        public int Popularity { get; set; }
        public ICollection<FilmCategory> Films { get; set; }
    }
}
