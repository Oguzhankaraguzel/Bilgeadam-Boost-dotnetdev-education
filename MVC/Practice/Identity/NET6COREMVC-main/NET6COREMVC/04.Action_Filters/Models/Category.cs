using System.ComponentModel.DataAnnotations;

namespace _04.Action_Filters.Models
{
    public class Category
    {
        [Range(0,int.MaxValue)]
        public int Count { get; set; }
    }
}
