namespace _02.Uygulama01.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
        public string Category { get; set; }

        public static List<Product> Products { get; } =  new List<Product>() {
            new Product(1,"Kalem",100,"Kırtasiye"),
            new Product(2,"Elma",200,"Meyve"),
            new Product(3,"Kağıt",300,"Kırtasiye"),
            new Product(4, "Kiraz", 0, "Meyve")
        };

        public Product(int id, string name, int stockQuantity, string category)
        {
            Id = id;
            Name = name;
            StockQuantity = stockQuantity;
            Category = category;
        }

        
    }
}
