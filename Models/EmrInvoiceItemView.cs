using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrInvoiceItemView
{
    public string InvoiceItemId { get; set; } = null!;

    public string InvoiceId { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? UnitId { get; set; }

    public decimal? Price { get; set; }

    public decimal? Cost { get; set; }

    public bool? DiscountPercentage { get; set; }

    public decimal? DiscountValue { get; set; }

    public string? Remarks { get; set; }

    public decimal? TotalCost { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedOn { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public decimal? Discount { get; set; }

    public string? AddedType { get; set; }

    public string? InvoiceNo { get; set; }

    public string? ItemName { get; set; }

    public string? ItemNo { get; set; }

    public string? VisitId { get; set; }

    public string? ItemUomid { get; set; }

    public string? UomLabel { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? AddedByCode { get; set; }

    public string? ItemGroupType { get; set; }

    public decimal? TotalQty { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public string? GenericName { get; set; }

    public string? ItemGroupName { get; set; }

    public string? ItemGroupId { get; set; }

    public decimal? Qty { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }

    public bool? IsCheckExpire { get; set; }

    public string? ItemExpireSave { get; set; }

    public bool? IsNotDoctorIncentive { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? UserName { get; set; }

    public string Reference { get; set; } = null!;

    public string Result { get; set; } = null!;

    public decimal? Focqty { get; set; }

    public string? Focunit { get; set; }

    public bool? IsFoc { get; set; }
}
