
using OrderingAppBackend.DTOs;

namespace OrderingAppBackend.Repositories;

public interface IOrderRepository
{
    Task<GetOrderDto> GetOrderByIdAsync(int orderId);
}