using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStoreIssueItem
{
    public string IssueItemId { get; set; } = null!;

    public string? IssueId { get; set; }

    public string? ItemId { get; set; }

    public string? RefId { get; set; }

    public string? GenericId { get; set; }

    public string? UnitId { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public decimal? IssuedQty { get; set; }

    public decimal? TotalIssueQty { get; set; }

    public string? IssueBarcodes { get; set; }

    public string? IssuedUom { get; set; }

    public string? IssueRemarks { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? LocationId { get; set; }

    public decimal? StockInHand { get; set; }
}
