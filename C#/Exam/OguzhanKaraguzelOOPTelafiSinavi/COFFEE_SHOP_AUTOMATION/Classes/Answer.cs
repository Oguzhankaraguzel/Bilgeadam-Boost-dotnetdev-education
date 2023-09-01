using COFFEE_SHOP_AUTOMATION.Classes.Item;

namespace COFFEE_SHOP_AUTOMATION.Classes
{
    public class Answer
    {
        public bool Result { get; set; }
        public string Reason { get; set; }
        public Order Order { get; set; }
        public Answer(bool result, string reason)
        {
            Result = result;
            Reason = reason;
        }

        public Answer(bool result, string reason, Order order)
        {
            Result = result;
            Reason = reason;
            Order = order;
        }
    }
}
