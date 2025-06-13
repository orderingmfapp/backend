using InzynierkaTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace InzynierkaTest.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetOrderById(int orderId)
    {
        return Ok(await _orderService.GetOrderByIdAsync(orderId));
    }
}