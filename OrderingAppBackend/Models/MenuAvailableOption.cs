using System;
using System.Collections.Generic;

namespace OrderingAppBackend.Models;

public partial class MenuAvailableOption
{
    public int Id { get; set; }

    public string OptionName { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public int MenuItemsId { get; set; }
}
