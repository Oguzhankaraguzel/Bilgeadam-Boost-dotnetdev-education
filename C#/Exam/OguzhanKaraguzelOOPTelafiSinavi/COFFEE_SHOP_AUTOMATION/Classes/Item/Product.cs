using COFFEE_SHOP_AUTOMATION.Classes.Abstract;
using COFFEE_SHOP_AUTOMATION.Enums;

namespace COFFEE_SHOP_AUTOMATION.Classes.Item
{
    public class Product : BaseProduct
    {
        public Product()
        {
            Ekstras = new List<Ekstras>();
        }
        public Size Size { get; set; }
        public ICollection<Ekstras> Ekstras;
    }
}
