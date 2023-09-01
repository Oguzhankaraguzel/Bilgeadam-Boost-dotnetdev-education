using COFFEE_SHOP_AUTOMATION.Classes;
using COFFEE_SHOP_AUTOMATION.Classes.Item;
using COFFEE_SHOP_AUTOMATION.Interfaces;
using COFFEE_SHOP_AUTOMATION.Program.Controller;

namespace COFFEE_SHOP_AUTOMATION.Program.Shop
{
    public class CoffeeShopController : IOrderStation
    {
        private readonly EmployeControl _employeeControl;
        private readonly ProductControl _productControl;
        Queue<Customer> _customers;
        public CoffeeShopController()
        {
            _employeeControl = new EmployeControl();
            _productControl = new ProductControl();
            _customers = new Queue<Customer>();
        }
        public TimeSpan CalculateAndSetPreperationTime(List<Product> products)
        {
            TimeSpan timeSpan = TimeSpan.Zero;
            foreach (Product product in products)
            {
                timeSpan.Add(product.PreperationTime);
                foreach (Ekstras item in product.Ekstras)
                {
                    timeSpan.Add(item.PreperationTime);
                }
            }
            return timeSpan;
        }

        public decimal CalculateTotalAmount(List<Product> products)
        {
            decimal amount = 0;
            foreach (Product product in products)
            {
                amount += product.Price;
                foreach (Ekstras item in product.Ekstras)
                {
                    amount += item.Price;
                }
            }
            return amount;
        }

        public async Task<Answer> TakeOrder(Customer customer)
        {
            if (_employeeControl.GetAvailableBarista() == null)
            {
                return new Answer(false, "There is no available barista. We cannot take an order. Please wait", customer.Order);
            }
            else
            {
                customer.Order.TotalAmounth = CalculateTotalAmount(customer.Order.Products);

                customer.Order.EstimatedWaitingTime = CalculateAndSetPreperationTime(customer.Order.Products);

                //ef core kullanıyormuş gibi düşünmekten mantık hatası içeriyor.
                customer.Order.CustomerId = customer.Id;

                await _employeeControl.PrepareOrder(_employeeControl.GetAvailableBarista(), customer.Order);
                _customers.Dequeue();

                return new Answer(true, $"Your order is preparing please wait. estimated waiting time : {customer.Order.EstimatedWaitingTime}, Amounth : {customer.Order.TotalAmounth}", customer.Order);
            }
        }

        public async Task<Answer> GetCustomerFromQueue()
        {
            return await TakeOrder(_customers.Peek());
        }

        public void AddCustomerToQueue(Customer customer)
        {
            _customers.Enqueue(customer);
        }

    }
}
