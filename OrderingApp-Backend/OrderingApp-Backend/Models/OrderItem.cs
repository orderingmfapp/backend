using System;
using System.Collections.Generic;

namespace InzynierkaTest.Models;

public partial class OrderItem
{
    public int Id { get; set; }

    public int Quantity { get; set; }

    public string Note { get; set; } = null!;

    public DateTime UpdatedAt { get; set; }

    public decimal CalculatedPrice { get; set; }

    public int OrdersId { get; set; }

    public int MenuItemsId { get; set; }
}
