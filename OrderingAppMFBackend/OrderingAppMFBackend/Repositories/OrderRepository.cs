using Microsoft.EntityFrameworkCore;
using OrderingAppMFBackend.DTOs;
using OrderingAppMFBackend.Models;

namespace OrderingAppMFBackend.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly OrderingAppContext _context;

    public OrderRepository(OrderingAppContext context)
    {
        _context = context;
    }
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