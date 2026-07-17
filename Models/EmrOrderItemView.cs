using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrOrderItemView
{
    public string OrderItemId { get; set; } = null!;

    public string OrderId { get; set; } = null!;

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

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? OrderNo { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public string? UomLabel { get; set; }

    public decimal? Discount { get; set; }

    public string? ItemUomid { get; set; }

    public string? AddedType { get; set; }

    public string? AddedByCode { get; set; }

    public string? ReferenceId { get; set; }

    public string? ItemGroupType { get; set; }

    public string? PatientId { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public decimal? TotalQty { get; set; }

    public string? GenericName { get; set; }

    public string? ItemGroupName { get; set; }

    public string? ItemGroupId { get; set; }

    public decimal? Qty { get; set; }
}
