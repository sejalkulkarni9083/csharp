using Microsoft.AspNetCore.Mvc;

namespace ProductCatalog.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new[]
            {
                new { id = 1, name = "Laptop", price = 75000 },
                new { id = 2, name = "Mobile", price = 25000 }
            };

            return Ok(products);
        }
    }
}
