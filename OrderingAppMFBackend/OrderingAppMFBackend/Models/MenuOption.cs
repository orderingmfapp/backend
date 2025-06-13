using System;
using System.Collections.Generic;

namespace OrderingAppMFBackend.Models;

public partial class MenuOption
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }
}
