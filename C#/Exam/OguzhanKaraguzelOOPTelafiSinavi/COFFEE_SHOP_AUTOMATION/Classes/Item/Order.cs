namespace COFFEE_SHOP_AUTOMATION.Classes.Item
{
    public class Order
    {
        public Order()
        {
            Products = new List<Product>();
        }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmounth { get; set; }
        public List<Product> Products { get; set; }
        public TimeSpan EstimatedWaitingTime { get; set; }
        public bool IsPrepared { get; set; } = false;
    }
}
