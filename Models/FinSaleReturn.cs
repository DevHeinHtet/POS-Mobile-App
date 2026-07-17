using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinSaleReturn
{
    public string ReturnId { get; set; } = null!;

    public string? ReturnNo { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string? ReturnStatus { get; set; }

    public string? InvoiceId { get; set; }

    public string? InvoiceNo { get; set; }

    public string? Reason { get; set; }

    public string? SupplierId { get; set; }

    public string? ReceiptById { get; set; }

    public string? LocationId { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public decimal? ReturnAmount { get; set; }

    public decimal? RefundAmount { get; set; }

    public decimal? Discount { get; set; }
}
