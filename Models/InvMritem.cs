using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvMritem
{
    public string MritemId { get; set; } = null!;

    public string? Mrid { get; set; }

    public string? ItemId { get; set; }

    public string? GenericId { get; set; }

    public decimal? RequestQty { get; set; }

    public decimal? IssueQty { get; set; }

    public decimal? RemainQty { get; set; }

    public decimal? TotalRemainQty { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? LocationId { get; set; }

    public string? UnitId { get; set; }
}
