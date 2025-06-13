using InzynierkaTest.Context;
using InzynierkaTest.DTOs;
using InzynierkaTest.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace InzynierkaTest.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly InzynierkaTestContext _context;
    public OrderRepository(InzynierkaTestContext context)
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