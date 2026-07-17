using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvoiceItemCost
{
    public string Id { get; set; } = null!;

    public string? InvoiceItemId { get; set; }

    public string? StockLedgerId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? UnitCost { get; set; }

    public decimal? TotalCost { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsFoc { get; set; }
}
