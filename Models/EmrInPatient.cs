using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrInPatient
{
    public string InPatientVoucherId { get; set; } = null!;

    public string InPatientVoucherNo { get; set; } = null!;

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

    public string? OtvoucherId { get; set; }

    public decimal? Otamount { get; set; }

    public decimal? FinalAmount { get; set; }

    public bool? IsUseDeposit { get; set; }

    public string? StaffById { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TaxPercent { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? DiscountPercent { get; set; }
}
