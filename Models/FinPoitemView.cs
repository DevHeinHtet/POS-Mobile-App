using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinPoitemView
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

    public string? Pono { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public string? GenericName { get; set; }

    public string? UomLabel { get; set; }

    public string? CurrencyExchangeName { get; set; }

    public string? CurrencyExchangeCode { get; set; }

    public decimal? CurrencyExchangeRate { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }

    public decimal? Focqty { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? Balance { get; set; }

    public decimal? FinalPrice { get; set; }

    public decimal? ReceivedQty { get; set; }

    public decimal? RemainingQty { get; set; }

    public string? SupplierName { get; set; }

    public string? InternalPono { get; set; }

    public DateTime? Podate { get; set; }

    public string? SupplierId { get; set; }

    public string? Status { get; set; }
}
