using Microsoft.EntityFrameworkCore;
using OrderingAppMFBackend.DTOs;
using OrderingAppMFBackend.Models;

namespace OrderingAppMFBackend.Repositories;

public class MenuOptionsRepository : IMenuOptionsRepository
{
    private readonly OrderingAppContext _context;

    public MenuOptionsRepository(OrderingAppContext context)
    {
        _context = context;
    }


    public async Task<List<GetMenuOptionsDto>> GetMenuOptionsAsync()
    {
        return await _context.MenuOptions
            .Include(m => m.Images)
            .Select(menuOption => new GetMenuOptionsDto
            {
                Id = menuOption.Id,
                Name = menuOption.Name,
                Description = menuOption.Description,
                Price = menuOption.Price,
                Images = menuOption.Images.Select(img => new MenuOptionImageDto
                {
                    ImageURL = img.ImageUrl,
                    ImageURLDescription = img.Description
                }).ToList()
            }).ToListAsync();
    }

    public async Task<MenuOption> AddMenuOptionAsync(AddMenuOptionDto menuOptionDto)
    {
        var menuOption = new MenuOption
        {
            Name = menuOptionDto.Name,
            Description = menuOptionDto.Description,
            Price = menuOptionDto.Price,
            Images = menuOptionDto.Images.Select(img => new MenuOptionsImage()
            {
                ImageUrl = img.ImageURL,
                Description = img.ImageURLDescription
            }).ToList()
        };
        
        _context.MenuOptions.Add(menuOption);
        await _context.SaveChangesAsync();
        return menuOption;
    }

    public async Task<bool> UpdateMenuOptionsAsync(int id, UpdateMenuOptionDto menuOptionDto)
    {
        var existing = await _context.MenuOptions
            .Include(m => m.Images)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (existing == null)
        {
            return false;
        }

        existing.Name = menuOptionDto.Name;
        existing.Description = menuOptionDto.Description;
        existing.Price = menuOptionDto.Price;
        
        _context.MenuOptionsImages.RemoveRange(existing.Images);

        foreach (var img in menuOptionDto.Images)
        {
            existing.Images.Add(new MenuOptionsImage
            {
                ImageUrl = img.ImageURL,
                Description = img.ImageURLDescription
            });
        }

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteMenuOptionsAsync(int id)
    {
        var existing = await _context.MenuOptions
            .Include(m => m.Images)
            .FirstOrDefaultAsync(m => m.Id == id);
        
        if (existing == null)
        {
            return false;
        }
        
        _context.MenuOptionsImages.RemoveRange(existing.Images);

        _context.MenuOptions.Remove(existing);
        await _context.SaveChangesAsync();
        return true;
    }
}