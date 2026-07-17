using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStockExceptionView
{
    public string StockExceptionId { get; set; } = null!;

    public DateTime? Date { get; set; }

    public string? UserName { get; set; }

    public string? Status { get; set; }

    public string? ExceptionType { get; set; }

    public string? Description { get; set; }

    public DateTime? RequestOn { get; set; }

    public DateTime? StatusOn { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Active { get; set; }

    public string? LastAction { get; set; }

    public string? ToLocationName { get; set; }

    public string? FromLocationName { get; set; }

    public string? ToStationName { get; set; }

    public string? FromStationName { get; set; }

    public string? FromLocation { get; set; }

    public string? ToLocation { get; set; }

    public string? FromStation { get; set; }

    public string? ToStation { get; set; }

    public string? RequestBy { get; set; }

    public string? RequestByName { get; set; }

    public string? StatusBy { get; set; }

    public string? StatusByName { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedByName { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ModifiedByName { get; set; }

    public string? ExceptionNo { get; set; }

    public string? SupplierName { get; set; }

    public string? SupplierId { get; set; }
}
