using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStoreReceiptItem
{
    public string ReceiptItemId { get; set; } = null!;

    public string? ReceiptId { get; set; }

    public string? ItemId { get; set; }

    public string? GenericId { get; set; }

    public decimal? RefQty { get; set; }

    public string? UnitId { get; set; }

    public decimal? ReceiptQty { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public decimal? TotalReceiptQty { get; set; }

    public string? LocationId { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? RefId { get; set; }
}
