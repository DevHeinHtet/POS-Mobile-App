using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvAdjustmentItem
{
    public string AdjustmentItemId { get; set; } = null!;

    public string AdjustmentId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal ActualQty { get; set; }

    public decimal SystemQty { get; set; }

    public decimal AdjustQty { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? Remark { get; set; }
}
