using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class StockLedger
{
    public string StockLedgerId { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? LocationId { get; set; }

    public string? ReferenceType { get; set; }

    public string? ReferenceId { get; set; }

    public string? PoitemId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? RemainingQty { get; set; }

    public decimal? UnitCost { get; set; }

    public bool? IsFoc { get; set; }

    public DateTime? CreatedDate { get; set; }
}
