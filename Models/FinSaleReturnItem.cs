using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinSaleReturnItem
{
    public string ReturnItemId { get; set; } = null!;

    public string? ReturnId { get; set; }

    public string? ItemId { get; set; }

    public decimal? TakenQty { get; set; }

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

    public decimal? Price { get; set; }

    public decimal? TotalCost { get; set; }
}
