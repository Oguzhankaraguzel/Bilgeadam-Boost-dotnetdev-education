using COFFEE_SHOP_AUTOMATION.Classes.Item;
using COFFEE_SHOP_AUTOMATION.Enums;

namespace COFFEE_SHOP_AUTOMATION.Classes
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public Order? Order { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
