using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStoreReceiptItemView
{
    public string ReceiptItemId { get; set; } = null!;

    public string? ReceiptId { get; set; }

    public string? ItemId { get; set; }

    public decimal? RefQty { get; set; }

    public decimal? ReceiptQty { get; set; }

    public string? LocationId { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? ReceiptNo { get; set; }

    public DateTime? ReceiptOn { get; set; }

    public string? ReceiptStatus { get; set; }

    public string? Reason { get; set; }

    public string? SupplierId { get; set; }

    public string? ReceiptById { get; set; }

    public string? SupplierName { get; set; }

    public string? ReceiptPersonName { get; set; }

    public string? ItemName { get; set; }

    public string? LocationName { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemGroupType { get; set; }

    public string? UomLabel { get; set; }

    public string? ItemUomid { get; set; }

    public string? UnitId { get; set; }

    public string? GenericId { get; set; }

    public string? GenericName { get; set; }

    public decimal Balance { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public decimal? TotalReceiptQty { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }

    public bool? IsCheckExpire { get; set; }

    public string? ReceiptLocation { get; set; }

    public string? BatchNos { get; set; }

    public string? SrrefId { get; set; }

    public string? SrrefType { get; set; }
}
