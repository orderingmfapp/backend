using System;
using System.Collections.Generic;

namespace OrderingAppMFBackend.Models;

public partial class ItemsOption
{
    public int Id { get; set; }

    public int MenuItemsId { get; set; }

    public int MenuOptionsId { get; set; }
    
    public virtual MenuItem MenuItem { get; set; } = null!;
    public virtual MenuOption MenuOption { get; set; } = null!;
}
