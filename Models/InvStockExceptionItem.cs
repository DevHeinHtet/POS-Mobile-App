using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStockExceptionItem
{
    public string StockExceptionItemId { get; set; } = null!;

    public string? StockExceptionId { get; set; }

    public string? GenericId { get; set; }

    public string? ItemId { get; set; }

    public string? ItemUomid { get; set; }

    public string? Qty { get; set; }

    public decimal? TotalQty { get; set; }

    public string? Price { get; set; }

    public string? Cost { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? Active { get; set; }

    public string? LastAction { get; set; }

    public string? ItemExpireSave { get; set; }
}
