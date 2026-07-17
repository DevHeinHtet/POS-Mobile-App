using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStockInItem
{
    public string StockInItemId { get; set; } = null!;

    public string? StockInId { get; set; }

    public string? ItemId { get; set; }

    public string? GenericId { get; set; }

    public decimal? InQty { get; set; }

    public string? UnitId { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public decimal? TotalInQty { get; set; }

    public decimal? Price { get; set; }

    public string? CurrencyExchangeId { get; set; }

    public decimal? TotalCost { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? ManufactureId { get; set; }

    public string? CountryId { get; set; }
}
