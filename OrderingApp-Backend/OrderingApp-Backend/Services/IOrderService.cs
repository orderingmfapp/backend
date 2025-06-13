using InzynierkaTest.DTOs;
using InzynierkaTest.Models;

namespace InzynierkaTest.Services;

public interface IOrderService
{
    public Task<GetOrderDto> GetOrderByIdAsync(int orderId);
}