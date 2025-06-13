using System;
using System.Collections.Generic;

namespace OrderingAppMFBackend.Models;

public partial class MenuOptionsImage
{
    public int Id { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int MenuOptionsId { get; set; }
}
