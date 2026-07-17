using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStockException
{
    public string StockExceptionId { get; set; } = null!;

    public string? ExceptionNo { get; set; }

    public DateTime? Date { get; set; }

    public string? UserName { get; set; }

    public string? Status { get; set; }

    public string? ExceptionType { get; set; }

    public string? Description { get; set; }

    public string? RequestBy { get; set; }

    public DateTime? RequestOn { get; set; }

    public string? StatusBy { get; set; }

    public DateTime? StatusOn { get; set; }

    public string? FromLocation { get; set; }

    public string? ToLocation { get; set; }

    public string? FromStation { get; set; }

    public string? ToStation { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? Active { get; set; }

    public string? LastAction { get; set; }

    public string? SupplierId { get; set; }
}
