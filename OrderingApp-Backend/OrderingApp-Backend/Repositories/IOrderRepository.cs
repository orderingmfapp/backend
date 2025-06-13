
using InzynierkaTest.DTOs;

public interface IOrderRepository
{
    Task<GetOrderDto> GetOrderByIdAsync(int orderId);
}