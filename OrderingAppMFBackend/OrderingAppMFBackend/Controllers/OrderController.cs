using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderingAppMFBackend.DTOs;
using OrderingAppMFBackend.Models;
using OrderingAppMFBackend.Repositories;

namespace OrderingAppMFBackend.Controllers;
[ApiController]
[Route("api/controller")]
public class OrderRepository : IOrderRepository
{
    private readonly OrderingAppContext _context;

    public OrderRepository(OrderingAppContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<GetOrderDto?> GetOrderByIdAsync(int orderId)
    {
        return await _context.Orders
            .Where(order => order.Id == orderId)
            .Select(order => new GetOrderDto
            {
                OrderPrice = order.OrderPrice,
                createdAt = order.CreatedAt,
                updatedAt = order.UpdatedAt,
                SessionId = order.SessionId,
                Note = order.Note
            })
            .FirstOrDefaultAsync();
    }
}