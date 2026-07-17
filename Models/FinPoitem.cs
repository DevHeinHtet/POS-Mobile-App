using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinPoitem
{
    public string PoitemId { get; set; } = null!;

    public string Poid { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? GenericId { get; set; }

    public decimal? Poqty { get; set; }

    public string? UnitId { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public decimal? TotalPoqty { get; set; }

    public decimal? Price { get; set; }

    public string? CurrencyExchangeId { get; set; }

    public decimal? TotalCost { get; set; }

    public string Remark { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public decimal? Focqty { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? Balance { get; set; }

    public decimal? FinalPrice { get; set; }

    public decimal? ReceivedQty { get; set; }

    public decimal? RemainingQty { get; set; }
}
