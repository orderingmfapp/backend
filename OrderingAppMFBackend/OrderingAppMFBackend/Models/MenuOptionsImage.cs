using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OrderingAppMFBackend.Models;

public partial class MenuOptionsImage
{
    public int Id { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int MenuOptionId { get; set; }
    [JsonIgnore]
    public MenuOption MenuOption { get; set; }
}
