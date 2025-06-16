using System;
using System.Collections.Generic;

namespace OrderingAppMFBackend.Models;

public partial class MenuItem
{
    public int Id { get; set; }

    public decimal Price { get; set; }

    public string NameEn { get; set; } = null!;

    public string? NamePl { get; set; }

    public string DescriptionEn { get; set; } = null!;

    public string? DescriptionPl { get; set; }

    public string Type { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool OnStock { get; set; }

    public int MenuItemsCategoriesId { get; set; }
    
    public virtual ICollection<ItemsOption> ItemsOptions { get; set; } = new List<ItemsOption>();

}
