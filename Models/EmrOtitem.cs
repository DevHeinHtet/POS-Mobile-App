using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrOtitem
{
    public string OtvoucherItemId { get; set; } = null!;

    public string? OtvoucherId { get; set; }

    public string? ItemId { get; set; }

    public string? UnitId { get; set; }

    public decimal? Price { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public decimal? TotalQty { get; set; }

    public decimal? Cost { get; set; }

    public bool? DiscountPercentage { get; set; }

    public decimal? DiscountValue { get; set; }

    public string? Remarks { get; set; }

    public decimal? TotalCost { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedOn { get; set; }

    public decimal? Discount { get; set; }

    public string? AddedType { get; set; }

    public decimal? Qty { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? ItemExpireSave { get; set; }
}
