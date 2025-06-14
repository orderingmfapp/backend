namespace OrderingAppMFBackend.DTOs;

public class UpdateMenuOptionDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public List<MenuOptionImageDto> Images { get; set; }
}