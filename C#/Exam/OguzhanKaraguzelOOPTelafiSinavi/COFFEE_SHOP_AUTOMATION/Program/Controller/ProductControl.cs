using COFFEE_SHOP_AUTOMATION.Classes.Item;
using COFFEE_SHOP_AUTOMATION.Interfaces;

namespace COFFEE_SHOP_AUTOMATION.Program.Controller
{
    public class ProductControl : IProduct
    {
        public List<Ekstras> _ekstra;
        public List<Product> _products;
        public ProductControl()
        {
            _ekstra = new List<Ekstras>
            {
                new Ekstras{ Name = "Syrup", Description = "Delicious", Price = 2, PreperationTime = TimeSpan.FromMinutes(1) },
                new Ekstras{ Name = "Sugar", Description = "Just Sugar", Price = 0, PreperationTime = TimeSpan.FromMinutes(0) },
                new Ekstras{ Name = "Chocolate Souce", Description = "Best choice for your coffee", Price = 5, PreperationTime = TimeSpan.FromMinutes(3) }
            };
            _products = new List<Product>
            {
                new Product{ Name = "Turkhis Coffee", Description = "BEST COFFEE IN THE WORLD", Price = 20, PreperationTime = TimeSpan.FromMinutes(10), Size = Enums.Size.medium},
                new Product{ Name = "Esppresso", Description = "A good taste from italy", Price = 25, PreperationTime = TimeSpan.FromMinutes(15), Size = Enums.Size.small },
                new Product{ Name = "Latte", Description = "frothy coffee with milk", Price = 15, PreperationTime = TimeSpan.FromMinutes(10), Size = Enums.Size.small },
                new Product{ Name = "Latte", Description = "frothy coffee with milk", Price = 20, PreperationTime = TimeSpan.FromMinutes(10), Size = Enums.Size.medium },
                new Product{ Name = "Latte", Description = "frothy coffee with milk", Price = 25, PreperationTime = TimeSpan.FromMinutes(10), Size = Enums.Size.large }
            };
        }
        public void AddEkstras(Ekstras ekstras)
        {
            _ekstra.Add(ekstras);
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Ekstras> GetEkstrasList()
        {
            return _ekstra;
        }

        public List<Product> GetProductList()
        {
            return _products;
        }
    }
}
