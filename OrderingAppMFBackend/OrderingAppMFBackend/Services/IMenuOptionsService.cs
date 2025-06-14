using OrderingAppMFBackend.DTOs;
using OrderingAppMFBackend.Models;

namespace OrderingAppMFBackend.Services;

public interface IMenuOptionsService
{
    Task<List<GetMenuOptionsDto>> GetMenuOptionsAsync();
    Task<MenuOption> AddMenuOptionAsync(AddMenuOptionDto menuOptionDto);
    public Task<bool> UpdateMenuOptionsAsync(int id, UpdateMenuOptionDto menuOptionDto);
    public Task<bool> DeleteMenuOptionsAsync(int id);
}