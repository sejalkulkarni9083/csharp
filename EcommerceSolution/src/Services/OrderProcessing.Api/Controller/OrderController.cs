using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    [HttpPost]
    public IActionResult PlaceOrder()
    {
        return Ok("Order placed successfully");
    }
}
