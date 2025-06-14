using System.ComponentModel.DataAnnotations;

namespace OrderingAppMFBackend.DTOs;

public class AddMenuOptionDto
{
    [Required][MaxLength(100)]
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public List<MenuOptionImageDto> Images { get; set; }
    
    
}