using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStockExceptionItemView
{
    public string? StockExceptionItemId { get; set; }

    public string? Qty { get; set; }

    public string? Cost { get; set; }

    public string? Price { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Active { get; set; }

    public string? LastAction { get; set; }

    public string? StockExceptionId { get; set; }

    public string? ItemUomid { get; set; }

    public string? UomLabel { get; set; }

    public string? ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public string? GenericName { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedByName { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ModifiedByName { get; set; }

    public string? GenericId { get; set; }

    public decimal? TotalQty { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }

    public string? ItemNo { get; set; }

    public bool? IsCheckExpire { get; set; }

    public string? ItemExpireSave { get; set; }

    public DateTime? RfDate { get; set; }
}
