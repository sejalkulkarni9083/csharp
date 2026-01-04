using ShoppingCartMVC.Models;

namespace ShoppingCartMVC.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 50000 },
            new Product { Id = 2, Name = "Phone", Price = 20000 },
            new Product { Id = 3, Name = "Headphones", Price = 2000 }
        };

        public List<Product> GetAll() => _products;

        public Product GetById(int id) =>
            _products.FirstOrDefault(p => p.Id == id);
    }
}
