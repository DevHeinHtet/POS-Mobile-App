using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstLuckyPrize
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }
}
