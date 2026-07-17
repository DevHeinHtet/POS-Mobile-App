using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstServiceTypeItemView
{
    public string ServiceTypeItemId { get; set; } = null!;

    public string? ServiceTypeId { get; set; }

    public string? ItemId { get; set; }

    public decimal? DefaultItemQty { get; set; }

    public decimal? ItemPrice { get; set; }

    public decimal? ItemCost { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? UnitId { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? ServiceTypeCode { get; set; }

    public string? Expr1 { get; set; }

    public string? ServiceTypeName { get; set; }

    public string? ItemName { get; set; }

    public string? UomLabel { get; set; }

    public string? Status { get; set; }

    public decimal? ShowSeq { get; set; }

    public string? UomcombineIds { get; set; }

    public string? UomcombineLabels { get; set; }

    public decimal? TotalQty { get; set; }

    public decimal? DefaultUnitQty { get; set; }
}
