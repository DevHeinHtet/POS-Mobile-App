using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrClinicServicesView
{
    public string ClinicServicesId { get; set; } = null!;

    public string ClinicVoucherId { get; set; } = null!;

    public string? ServiceTypeId { get; set; }

    public string? ServiceTypePersonId { get; set; }

    public string? ServiceTypeSubName { get; set; }

    public decimal? Price { get; set; }

    public decimal? Time { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? ClinicVoucherNo { get; set; }

    public string? ServiceTypeName { get; set; }

    public string? ServiceTypeCode { get; set; }

    public string? DoctorName { get; set; }

    public string? DoctorNo { get; set; }

    public string? ServiceSubCateName { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? PayAmount { get; set; }

    public decimal? Remain { get; set; }

    public decimal? ServicePrice { get; set; }

    public string? VoucherStatus { get; set; }

    public DateTime? VoucherDate { get; set; }

    public bool? IsServicePriceFoc { get; set; }

    public bool? IsServiceTypeFoc { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? Balance { get; set; }

    public decimal? DiscountAmount { get; set; }

    public string? BranchId { get; set; }

    public string? BranchName { get; set; }

    public bool? IsShowInVoucher { get; set; }

    public string? VisitNo { get; set; }

    public string? VisitId { get; set; }
}
