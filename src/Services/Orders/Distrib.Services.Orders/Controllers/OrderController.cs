using Microsoft.AspNetCore.Mvc;

namespace Distrib.Services.Orders.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
  

    [HttpGet("{orderId:guid}")]
    public ActionResult<OrderDto> GetOrder(Guid orderId)
    {
        return Ok(new OrderDto(orderId));
    }

    [HttpPost(Name = "add-order")]
    public ActionResult<Guid> AddOrder(OrderDto order)
    {
        return Ok(Guid.NewGuid());
    }
    
    public record OrderDto(Guid OrderId);
}