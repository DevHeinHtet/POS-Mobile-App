using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStockInView
{
    public string StockInId { get; set; } = null!;

    public string? StockInNo { get; set; }

    public DateTime? StockInDate { get; set; }

    public string? StockInStatus { get; set; }

    public string? SupplierId { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? SupplierName { get; set; }

    public string? SupplierCode { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? CountryId { get; set; }

    public string? LocationId { get; set; }

    public string? CountryName { get; set; }

    public string? LocationName { get; set; }

    public string? LocationCode { get; set; }

    public string? InvoiceNo { get; set; }

    public string? RefNo { get; set; }

    public string? StockInSupplierName { get; set; }

    public string? StockInSupplierId { get; set; }
}
