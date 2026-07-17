using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvLocationMoveItemView
{
    public string LocationMoveItemId { get; set; } = null!;

    public string? LocationMoveId { get; set; }

    public string? ItemId { get; set; }

    public decimal? MoveQuantity { get; set; }

    public string? UnitId { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public decimal? TotalMoveQty { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? MoveNo { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public string? UomLabel { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? GenericId { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }

    public string? ItemGroupId { get; set; }

    public string? ItemGroupName { get; set; }

    public string? GenericName { get; set; }

    public string? Status { get; set; }

    public DateTime? MoveDate { get; set; }

    public string? LocationIdfrom { get; set; }

    public string? LocationIdto { get; set; }

    public string? ItemExpireSave { get; set; }

    public bool? IsCheckExpire { get; set; }
}
