using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStoreReceipt
{
    public string ReceiptId { get; set; } = null!;

    public string? ReceiptNo { get; set; }

    public DateTime? ReceiptOn { get; set; }

    public string? ReceiptStatus { get; set; }

    public string? SrrefType { get; set; }

    public string? SrrefId { get; set; }

    public string? SrrefNo { get; set; }

    public string? Reason { get; set; }

    public string? SupplierId { get; set; }

    public string? CountryId { get; set; }

    public string? ReceiptById { get; set; }

    public string? LocationId { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
