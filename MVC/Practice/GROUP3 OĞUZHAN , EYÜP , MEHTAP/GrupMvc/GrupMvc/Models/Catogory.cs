namespace GrupMvc.Models
{
    public class Catogory
    {
        public Catogory()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
