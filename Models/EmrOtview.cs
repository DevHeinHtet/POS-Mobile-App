using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrOtview
{
    public string OtvoucherId { get; set; } = null!;

    public string OtvoucherNo { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string? LocationId { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? AdmissionDate { get; set; }

    public string? VoucherStatus { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? PayAmount { get; set; }

    public decimal? DepositAmount { get; set; }

    public decimal? Remain { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public string? LocationName { get; set; }

    public string? LocationCode { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public bool? UseDeposit { get; set; }

    public string? DepositId { get; set; }

    public decimal? Deposit { get; set; }

    public decimal? UseAmount { get; set; }

    public decimal? Remains { get; set; }

    public decimal? InPatientPayAmount { get; set; }

    public string? OperationType { get; set; }

    public string? UserName { get; set; }

    public DateTime? DepositDate { get; set; }

    public string? StaffById { get; set; }

    public string? OperatorName { get; set; }
}
