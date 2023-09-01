using COFFEE_SHOP_AUTOMATION.Classes;
using COFFEE_SHOP_AUTOMATION.Classes.Item;

namespace COFFEE_SHOP_AUTOMATION.Interfaces
{
    public interface IOrderStation
    {
        Task<Answer> TakeOrder(Customer customer);
        decimal CalculateTotalAmount(List<Product> products);
        TimeSpan CalculateAndSetPreperationTime(List<Product> products);
    }
}
