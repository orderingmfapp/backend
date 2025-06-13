using System;
using System.Collections.Generic;

namespace OrderingAppMFBackend.Models;

public partial class Order
{
    public int Id { get; set; }

    public decimal OrderPrice { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int SessionId { get; set; }

    public string Note { get; set; } = null!;
}
