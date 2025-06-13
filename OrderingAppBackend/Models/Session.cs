using System;
using System.Collections.Generic;

namespace OrderingAppBackend.Models;

public partial class Session
{
    public int Id { get; set; }

    public int? TableNumber { get; set; }

    public int UserId { get; set; }

    public TimeOnly TimeToExpire { get; set; }

    public string Status { get; set; } = null!;

    public string? PaymentMethod { get; set; }

    public int NumberOfClients { get; set; }

    public DateTime CreatedAt { get; set; }

    public decimal TotalSessionPrice { get; set; }

    public int PromotionsId { get; set; }

    public int MenuOptionsId { get; set; }
}
