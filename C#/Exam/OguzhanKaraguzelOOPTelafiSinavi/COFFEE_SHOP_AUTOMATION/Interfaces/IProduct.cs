using COFFEE_SHOP_AUTOMATION.Classes.Item;

namespace COFFEE_SHOP_AUTOMATION.Interfaces
{
    public interface IProduct
    {
        void AddProduct(Product product);
        List<Product> GetProductList();
        void AddEkstras(Ekstras ekstras);
        List<Ekstras> GetEkstrasList();
    }
}
