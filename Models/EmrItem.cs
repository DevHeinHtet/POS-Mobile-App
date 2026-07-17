using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrItem
{
    public string ItemId { get; set; } = null!;

    public string? ItemNo { get; set; }

    public string ItemName { get; set; } = null!;

    public string ItemGroupId { get; set; } = null!;

    public string? GenericId { get; set; }

    public decimal DefaultItemPrice { get; set; }

    public string AlertNote { get; set; } = null!;

    public string Remark { get; set; } = null!;

    public int? WarningLevelQuantity { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? ShortCode { get; set; }

    public string? Status { get; set; }

    public string InventUomid { get; set; } = null!;

    public string? ShowSeq { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }

    public bool? IsMaterial { get; set; }

    public bool? IsStockCount { get; set; }

    public bool? IsCheckExpire { get; set; }

    public string? CsParentItemId { get; set; }

    public bool? IsCs { get; set; }

    public string? CssupplierId { get; set; }

    public string? BrandId { get; set; }

    public string? SupplierId { get; set; }

    public string? ManualCode { get; set; }
}
