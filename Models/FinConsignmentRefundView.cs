using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinConsignmentRefundView
{
    public string ConRefundId { get; set; } = null!;

    public string? ConRefundNo { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? SupplierId { get; set; }

    public decimal? Amount { get; set; }

    public string? Status { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string CreatedByCode { get; set; } = null!;

    public string ModifiedByCode { get; set; } = null!;

    public string SupplierCode { get; set; } = null!;

    public string SupplierName { get; set; } = null!;

    public DateOnly VoucherDate { get; set; }
}
