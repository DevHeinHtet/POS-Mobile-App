using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStockRequest
{
    public string StockRequestId { get; set; } = null!;

    public string RefId { get; set; } = null!;

    public string RefType { get; set; } = null!;

    public string RefNo { get; set; } = null!;

    public DateOnly RefDate { get; set; }

    public DateTime RequestOn { get; set; }

    public decimal RequestQty { get; set; }

    public decimal? TotalRequestQty { get; set; }

    public decimal? IssueQty { get; set; }

    public decimal? TotalIssueQty { get; set; }

    public decimal? RemainQty { get; set; }

    public decimal? TotalRemainQty { get; set; }

    public string? DefaultUnit { get; set; }

    public string RequestTitle { get; set; } = null!;

    public string SubRefId { get; set; } = null!;

    public string SubRefType { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? UnitId { get; set; }

    public string? StationId { get; set; }

    public string? LocationId { get; set; }

    public string? LocationGroup { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }
}
