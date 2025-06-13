using OrderingAppMFBackend.DTOs;

namespace OrderingAppMFBackend.Repositories;

public interface IOrderRepository
{
    Task<GetOrderDto> GetOrderByIdAsync(int orderId);
}