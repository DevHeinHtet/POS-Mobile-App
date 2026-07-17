using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstServiceTypeItem
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

    public decimal? TotalQty { get; set; }

    public decimal? DefaultUnitQty { get; set; }
}
