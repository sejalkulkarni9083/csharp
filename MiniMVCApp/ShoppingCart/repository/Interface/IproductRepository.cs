using ShoppingCartMVC.Models;

namespace ShoppingCartMVC.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
    }
}
