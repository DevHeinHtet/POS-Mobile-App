using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStockInItemView
{
    public string StockInItemId { get; set; } = null!;

    public string? StockInId { get; set; }

    public string? ItemId { get; set; }

    public decimal? InQty { get; set; }

    public string? UnitId { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public decimal? TotalInQty { get; set; }

    public decimal? Price { get; set; }

    public string? CurrencyExchangeId { get; set; }

    public decimal? TotalCost { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? StockInNo { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public string? UomLabel { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? CurrencyExchangeCode { get; set; }

    public string? CurrencyExchangeName { get; set; }

    public decimal? CurrencyExchangeRate { get; set; }

    public string? Remark { get; set; }

    public string? GenericId { get; set; }

    public string? GenericName { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }

    public string? SupplierCode { get; set; }

    public string? SupplierName { get; set; }

    public string? ManufactureId { get; set; }

    public string? CountryId { get; set; }

    public string? CountryName { get; set; }

    public string? LocationId { get; set; }

    public string? StockInStatus { get; set; }

    public DateTime? StockInDate { get; set; }

    public bool? IsCheckExpire { get; set; }
}
