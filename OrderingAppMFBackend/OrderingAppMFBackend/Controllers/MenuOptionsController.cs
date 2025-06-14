using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using OrderingAppMFBackend.DTOs;
using OrderingAppMFBackend.Models;
using OrderingAppMFBackend.Services;

namespace OrderingAppMFBackend.Controllers;

[ApiController]
[Route("api/menuoptions")]
public class MenuOptionsController : ControllerBase
{
    private readonly IMenuOptionsService _menuOptionsService;

    public MenuOptionsController(IMenuOptionsService menuOptionsService)
    {
        _menuOptionsService = menuOptionsService;
    }
    [HttpGet]
    public async Task<IActionResult> GetMenuOptionsAsync()
    {
        return Ok(await _menuOptionsService.GetMenuOptionsAsync());
    }

    [HttpPost]
    public async Task<ActionResult<MenuOption>> AddMenuOption([FromBody] AddMenuOptionDto menuOptionDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _menuOptionsService.AddMenuOptionAsync(menuOptionDto);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateMenuOptionAsync(int id, [FromBody] UpdateMenuOptionDto menuOptionDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var success = await _menuOptionsService.UpdateMenuOptionsAsync(id, menuOptionDto);
        if (!success)
        {
            return NotFound();
        }

        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMenuOption(int id)
    {
        var success = await _menuOptionsService.DeleteMenuOptionsAsync(id);
        if (!success)
            return NotFound();

        return NoContent();
    }
    

}