using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/cart")]
public class CartController : ControllerBase
{
    [HttpPost("add")]
    public IActionResult Add()
    {
        return Ok("Item added to cart");
    }
}
