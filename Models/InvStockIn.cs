using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStockIn
{
    public string StockInId { get; set; } = null!;

    public string? StockInNo { get; set; }

    public string? InvoiceNo { get; set; }

    public string? RefNo { get; set; }

    public DateTime? StockInDate { get; set; }

    public string? StockInStatus { get; set; }

    public string? LocationId { get; set; }

    public string? SupplierId { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CountryId { get; set; }

    public string? StockInSupplierId { get; set; }
}
