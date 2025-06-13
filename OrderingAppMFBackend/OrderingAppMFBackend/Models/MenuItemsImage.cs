using System;
using System.Collections.Generic;

namespace OrderingAppMFBackend.Models;

public partial class MenuItemsImage
{
    public int Id { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime AddedAt { get; set; }

    public int MenuItemsId { get; set; }
}
