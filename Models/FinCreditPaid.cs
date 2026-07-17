using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinCreditPaid
{
    public string CreditPaidId { get; set; } = null!;

    public string CreditPaidNo { get; set; } = null!;

    public DateTime PaidDate { get; set; }

    public string SupplierId { get; set; } = null!;

    public decimal VouncherAmount { get; set; }

    public decimal OtherAmount1 { get; set; }

    public string OtherTitle1 { get; set; } = null!;

    public decimal PaidAmount { get; set; }

    public string Remark { get; set; } = null!;

    public string? Status { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
