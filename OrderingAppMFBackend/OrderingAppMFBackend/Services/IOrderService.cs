using OrderingAppMFBackend.DTOs;

namespace OrderingAppMFBackend.Services;

public interface IOrderService
{
    public Task<GetOrderDto> GetOrderByIdAsync(int orderId);
}