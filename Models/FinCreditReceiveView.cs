using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinCreditReceiveView
{
    public string CreditReceivedId { get; set; } = null!;

    public string CreditReceivedNo { get; set; } = null!;

    public DateTime ReceivedDate { get; set; }

    public string CustomerId { get; set; } = null!;

    public decimal VouncherAmount { get; set; }

    public decimal OtherAmount1 { get; set; }

    public string OtherTitle1 { get; set; } = null!;

    public decimal ReceivedAmount { get; set; }

    public string Remark { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public string? Status { get; set; }
}
