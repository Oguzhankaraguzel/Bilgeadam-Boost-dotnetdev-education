using COFFEE_SHOP_AUTOMATION.Classes;
using COFFEE_SHOP_AUTOMATION.Classes.Item;
using COFFEE_SHOP_AUTOMATION.Interfaces;

namespace COFFEE_SHOP_AUTOMATION.Program.Controller
{
    public class EmployeControl : IEmployee
    {
        public List<Employee> _employees;
        public EmployeControl()
        {
            _employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Joe", Department = Enums.Department.Cashier},
                new Employee { Id = 2, Name = "Jack", Department = Enums.Department.Barista},
                new Employee { Id = 3, Name = "William", Department = Enums.Department.Barista},
                new Employee { Id = 4, Name = "Avarel", Department = Enums.Department.Barista}
            };
        }

        public Employee? GetAvailableBarista()
        {
            return _employees.First(e => e.IsAvailable == true && e.Department == Enums.Department.Barista);
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public async Task<Order> PrepareOrder(Employee employee, Order order)
        {
            employee.Order = order;
            employee.IsAvailable = false;
            System.Threading.Thread.Sleep(order.EstimatedWaitingTime);
            employee.IsAvailable = true;
            order.IsPrepared = true;
            return order;
        }

        public void SetEmployeeDepartment(Employee employee, Enums.Department department)
        {
            employee.Department = department;
        }
    }
}
