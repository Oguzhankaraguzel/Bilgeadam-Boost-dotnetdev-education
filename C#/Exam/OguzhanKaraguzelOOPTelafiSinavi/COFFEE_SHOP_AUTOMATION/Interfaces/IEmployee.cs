using COFFEE_SHOP_AUTOMATION.Classes;
using COFFEE_SHOP_AUTOMATION.Classes.Item;

namespace COFFEE_SHOP_AUTOMATION.Interfaces
{
    public interface IEmployee
    {
        Employee? GetAvailableBarista();
        void SetEmployeeDepartment(Employee employee, Enums.Department department);
        Task<Order> PrepareOrder(Employee employee, Order order);
        List<Employee> GetEmployees();
    }
}
