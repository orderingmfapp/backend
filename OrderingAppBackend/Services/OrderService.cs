using OrderingAppBackend.DTOs;
using OrderingAppBackend.Models;
using OrderingAppBackend.Repositories;

namespace OrderingAppBackend.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Task<GetOrderDto> GetOrderByIdAsync(int orderId)
    {
        return _orderRepository.GetOrderByIdAsync(orderId);
    }
    
}