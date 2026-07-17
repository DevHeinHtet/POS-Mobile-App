using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvLocationMoveItem
{
    public string LocationMoveItemId { get; set; } = null!;

    public string? LocationMoveId { get; set; }

    public string? ItemId { get; set; }

    public string? GenericId { get; set; }

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

    public string? ItemExpireSave { get; set; }
}
