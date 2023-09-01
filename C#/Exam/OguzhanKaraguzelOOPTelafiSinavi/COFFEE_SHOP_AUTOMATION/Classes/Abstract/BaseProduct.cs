namespace COFFEE_SHOP_AUTOMATION.Classes.Abstract
{
    public abstract class BaseProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan PreperationTime { get; set; }
        public decimal Price { get; set; }
    }
}
