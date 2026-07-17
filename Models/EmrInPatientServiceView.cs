using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrInPatientServiceView
{
    public string InPatientServiceId { get; set; } = null!;

    public string? InPatientVoucherId { get; set; }

    public string? ServiceTypeId { get; set; }

    public string? ServiceTypePersonId { get; set; }

    public string? ServiceTypeSubName { get; set; }

    public decimal? Price { get; set; }

    public decimal? Time { get; set; }

    public decimal? Total { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? InPatientVoucherNo { get; set; }

    public decimal? PayAmount { get; set; }

    public decimal? Remain { get; set; }

    public string? ServiceSubCateName { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? DepositAmount { get; set; }

    public string? ServiceTypeName { get; set; }

    public string? ServiceTypeCode { get; set; }

    public string? DoctorName { get; set; }

    public string? DoctorNo { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? VoucherStatus { get; set; }

    public decimal? ServicePrice { get; set; }

    public bool? IsStfoc { get; set; }

    public bool? IsSpfoc { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? Balance { get; set; }

    public decimal? DiscountAmount { get; set; }

    public string? BranchId { get; set; }

    public string? BranchName { get; set; }

    public bool? IsShowInVoucher { get; set; }
}
