using System;
using System.Collections.Generic;

namespace OrderingAppBackend.Models;

public partial class Promotion
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string PromoCode { get; set; } = null!;

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public decimal Discount { get; set; }

    public bool IsActive { get; set; }

    public int? MaxNumberOfUsages { get; set; }
}
