using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/shipments")]
public class ShipmentController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateShipment()
    {
        return Ok("Shipment created");
    }
}
