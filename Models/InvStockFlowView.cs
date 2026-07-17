using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStockFlowView
{
    public string RefId { get; set; } = null!;

    public string RefType { get; set; } = null!;

    public string StockFlowId { get; set; } = null!;

    public string RefNo { get; set; } = null!;

    public DateOnly RefDate { get; set; }

    public DateTime FlowOn { get; set; }

    public string FlowBy { get; set; } = null!;

    public decimal FlowQty { get; set; }

    public string FlowTitle { get; set; } = null!;

    public string FlowType { get; set; } = null!;

    public string SubRefId { get; set; } = null!;

    public string SubRefType { get; set; } = null!;

    public string? OwnerRefId { get; set; }

    public string? OwnerRefType { get; set; }

    public string? ItemId { get; set; }

    public string? LocationId { get; set; }

    public string? LocationGroup { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? Channel { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? SalePerson { get; set; }
}
