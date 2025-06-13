using OrderingAppBackend.DTOs;
using OrderingAppBackend.Models;

namespace OrderingAppBackend.Services;

public interface IOrderService
{
    public Task<GetOrderDto> GetOrderByIdAsync(int orderId);
}