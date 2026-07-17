using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvExpireInView
{
    public string ExpireInId { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? LocationId { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public decimal? InQty { get; set; }

    public string? RefId { get; set; }

    public string? RefType { get; set; }

    public decimal? TotalOutQty { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? ItemNo { get; set; }

    public string? LocationName { get; set; }

    public string? LocationCode { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? ExStatus { get; set; }

    public decimal? RemainQty { get; set; }

    public DateTime? ExDate { get; set; }

    public string? BatchNo { get; set; }
}
