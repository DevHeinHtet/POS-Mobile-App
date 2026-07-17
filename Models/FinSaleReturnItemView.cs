using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinSaleReturnItemView
{
    public string? ReturnId { get; set; }

    public string ReturnItemId { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? UnitId { get; set; }

    public decimal? ReturnQty { get; set; }

    public decimal? TotalQty { get; set; }

    public string? FromLocationId { get; set; }

    public string? ToLocationId { get; set; }

    public string? Status { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public string? UomLabel { get; set; }

    public string? UomcombineIds { get; set; }

    public string? ItemUomid { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? InvoiceNo { get; set; }

    public string? InvoiceId { get; set; }

    public decimal? TakenQty { get; set; }

    public decimal? Price { get; set; }

    public decimal? TotalCost { get; set; }

    public string? FromLocationName { get; set; }

    public string? ToLocationName { get; set; }

    public bool? IsCheckExpire { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string? ReturnStatus { get; set; }
}
