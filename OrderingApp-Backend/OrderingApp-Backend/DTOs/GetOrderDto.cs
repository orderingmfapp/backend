namespace InzynierkaTest.DTOs;

public class GetOrderDto
{
    public decimal OrderPrice { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public int SessionId { get; set; }
    public string Note { get; set; }
    
}