using OrderingAppMFBackend.DTOs;
using OrderingAppMFBackend.Models;

namespace OrderingAppMFBackend.Repositories;

public interface IMenuOptionsRepository
{
    public Task<List<GetMenuOptionsDto>> GetMenuOptionsAsync();
    public Task<MenuOption> AddMenuOptionAsync(AddMenuOptionDto menuOptionDto);
    public Task<bool> UpdateMenuOptionsAsync(int id, UpdateMenuOptionDto menuOptionDto);
    public Task<bool> DeleteMenuOptionsAsync(int id);
}