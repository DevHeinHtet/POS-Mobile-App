using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrClinicView
{
    public string ClinicVoucherId { get; set; } = null!;

    public string ClinicVoucherNo { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? LocationId { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? VoucherStatus { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? PayAmount { get; set; }

    public decimal? Remain { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerCode { get; set; }

    public string? LocationName { get; set; }

    public string? LocationCode { get; set; }

    public string? Remark { get; set; }

    public string? DoctorName { get; set; }

    public string? UserName { get; set; }

    public bool? IsUseDeposit { get; set; }

    public decimal? DepositAmount { get; set; }

    public string? ContactPerson { get; set; }

    public string? BranchAddress { get; set; }

    public string? BranchType { get; set; }

    public string? BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? VisitNo { get; set; }

    public string? VisitId { get; set; }

    public string? OperatorName { get; set; }

    public string? StaffById { get; set; }

    public bool? UseClinicFee { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TaxPercent { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? DiscountPercentage { get; set; }
}
