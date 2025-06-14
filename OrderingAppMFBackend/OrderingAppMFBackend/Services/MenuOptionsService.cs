using OrderingAppMFBackend.DTOs;
using OrderingAppMFBackend.Models;
using OrderingAppMFBackend.Repositories;

namespace OrderingAppMFBackend.Services;

public class MenuOptionsService : IMenuOptionsService
{
    private readonly IMenuOptionsRepository _menuOptionsRepository;

    public MenuOptionsService(IMenuOptionsRepository menuOptionsRepository)
    {
        _menuOptionsRepository = menuOptionsRepository;
    }
    
    
    public async Task<List<GetMenuOptionsDto>> GetMenuOptionsAsync()
    {
        return await _menuOptionsRepository.GetMenuOptionsAsync();
    }

    public async Task<MenuOption> AddMenuOptionAsync(AddMenuOptionDto menuOptionDto)
    {
        return await _menuOptionsRepository.AddMenuOptionAsync(menuOptionDto);
    }

    public async Task<bool> UpdateMenuOptionsAsync(int id, UpdateMenuOptionDto menuOptionDto)
    {
        return await _menuOptionsRepository.UpdateMenuOptionsAsync(id, menuOptionDto);
    }

    public async Task<bool> DeleteMenuOptionsAsync(int id)
    {
        return await _menuOptionsRepository.DeleteMenuOptionsAsync(id);
    }
}