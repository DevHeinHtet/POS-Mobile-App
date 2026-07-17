using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrLuckyIncome
{
    public Guid Id { get; set; }

    public string LuckyId { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal DiscountPercent { get; set; }

    public decimal DiscountAmount { get; set; }

    public int Qty { get; set; }

    public string Type { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
