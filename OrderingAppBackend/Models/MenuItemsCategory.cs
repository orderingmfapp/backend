using System;
using System.Collections.Generic;

namespace OrderingAppBackend.Models;
public partial class MenuItemsCategory
{
    public int Id { get; set; }

    public string NameEn { get; set; } = null!;

    public string NamePl { get; set; } = null!;
}
