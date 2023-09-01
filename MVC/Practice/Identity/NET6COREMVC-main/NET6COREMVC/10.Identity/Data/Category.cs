using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10.Identity.Data
{
    public class Category
    {
        
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
    }
}
