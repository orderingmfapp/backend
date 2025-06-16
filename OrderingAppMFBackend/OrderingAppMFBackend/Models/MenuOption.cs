using System;
using System.Collections;
using System.Collections.Generic;

namespace OrderingAppMFBackend.Models;

public partial class MenuOption
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }
    public ICollection<MenuOptionsImage> Images { get; set; } = new List<MenuOptionsImage>();

    public virtual ICollection<ItemsOption> ItemsOptions { get; set; } = new List<ItemsOption>();
}
