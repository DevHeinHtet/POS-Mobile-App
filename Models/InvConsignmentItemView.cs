using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvConsignmentItemView
{
    public string? Csid { get; set; }

    public string? Csno { get; set; }

    public string? Remark { get; set; }

    public string CsitemId { get; set; } = null!;

    public string? RefItemId { get; set; }

    public string? CsrealItemId { get; set; }

    public decimal? InQty { get; set; }

    public string? UnitId { get; set; }

    public decimal? Price { get; set; }

    public decimal? Cost { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? UomLabel { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }

    public string? ItemName { get; set; }

    public string? StoreId { get; set; }

    public bool? IsCheckExpire { get; set; }

    public decimal? DefQty { get; set; }

    public decimal? TotalQty { get; set; }

    public DateTime? Date { get; set; }

    public string? Status { get; set; }
}
