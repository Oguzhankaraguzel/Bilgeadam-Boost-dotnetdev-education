using COFFEE_SHOP_AUTOMATION.Classes.Item;

namespace COFFEE_SHOP_AUTOMATION.Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Order Order { get; set; }
    }
}
