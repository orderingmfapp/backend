using System;
using System.Collections.Generic;

namespace OrderingAppMFBackend.Models;

public partial class ItemsOption
{
    public int Id { get; set; }

    public int MenuItemsId { get; set; }

    public int MenuOptionsId { get; set; }
}
