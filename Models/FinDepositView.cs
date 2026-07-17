using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinDepositView
{
    public string DepositId { get; set; } = null!;

    public string? DepositVoucherNo { get; set; }

    public string? RefNo { get; set; }

    public string? CustomerId { get; set; }

    public DateTime? DepositDate { get; set; }

    public string? VoucherStatus { get; set; }

    public decimal? Deposit { get; set; }

    public decimal? UseAmount { get; set; }

    public decimal? Remains { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? SalePersonId { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? CustomerName { get; set; }

    public string? ApprovedbyId { get; set; }

    public string? Remark { get; set; }

    public string? OperatorName { get; set; }

    public string? CustomerCode { get; set; }
}
