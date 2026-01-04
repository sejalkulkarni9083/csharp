using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ShoppingCartMVC.Models;

namespace ShoppingCartMVC.Services
{
    public class CartService : ICartService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string SessionKey = "Cart";

        public CartService(IHttpContextAccessor accessor)
        {
            _httpContextAccessor = accessor;
        }

        public List<CartItem> GetCart()
        {
            var session = _httpContextAccessor.HttpContext.Session;
            var cartJson = session.GetString(SessionKey);

            return cartJson == null
                ? new List<CartItem>()
                : JsonConvert.DeserializeObject<List<CartItem>>(cartJson);
        }

        public void AddToCart(Product product)
        {
            var cart = GetCart();
            var item = cart.FirstOrDefault(c => c.Product.Id == product.Id);

            if (item != null)
                item.Quantity++;
            else
                cart.Add(new CartItem { Product = product, Quantity = 1 });

            SaveCart(cart);
        }

        public void Remove(int productId)
        {
            var cart = GetCart();
            cart.RemoveAll(c => c.Product.Id == productId);
            SaveCart(cart);
        }

        private void SaveCart(List<CartItem> cart)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            session.SetString(SessionKey, JsonConvert.SerializeObject(cart));
        }
    }
}
