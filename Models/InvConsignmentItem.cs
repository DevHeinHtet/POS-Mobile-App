using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvConsignmentItem
{
    public string CsitemId { get; set; } = null!;

    public string? Csid { get; set; }

    public string? RefItemId { get; set; }

    public string? CsrealItemId { get; set; }

    public decimal? InQty { get; set; }

    public decimal? DefQty { get; set; }

    public decimal? TotalQty { get; set; }

    public string? UnitId { get; set; }

    public decimal? Price { get; set; }

    public decimal? Cost { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
