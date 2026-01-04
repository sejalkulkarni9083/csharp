using ShoppingCartMVC.Models;

namespace ShoppingCartMVC.Services
{
    public interface ICartService
    {
        void AddToCart(Product product);
        List<CartItem> GetCart();
        void Remove(int productId);
    }
}
