using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinCreditReceiveItem
{
    public string CreditReceivedItemId { get; set; } = null!;

    public string CreditReceivedId { get; set; } = null!;

    public string RefId { get; set; } = null!;

    public decimal? RemainAmount { get; set; }

    public decimal ItemAmount { get; set; }

    public string Remark { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public decimal? DepositAmount { get; set; }
}
