using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrInvoiceView
{
    public string InvoiceId { get; set; } = null!;

    public string? InvoiceNo { get; set; }

    public string? VisitId { get; set; }

    public string? PatientId { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? Status { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? DiscountPercent { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? Balance { get; set; }

    public string? Other1Remark { get; set; }

    public decimal? Other1Amount { get; set; }

    public string? Other2Remark { get; set; }

    public decimal? Other2Amount { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public decimal? InvoicePayment { get; set; }

    public string? CurrencyExchangeCode { get; set; }

    public string? CurrencyExchangeName { get; set; }

    public string? CurrencyExchangeId { get; set; }

    public decimal? CurrencyExchangeRate { get; set; }

    public string? LocationId { get; set; }

    public string? LocationName { get; set; }

    public string? LocationCode { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public string? ContactInfo { get; set; }

    public string? ContactPerson { get; set; }

    public string? OrderNo { get; set; }

    public decimal? Prepaid { get; set; }

    public string? DoctorName { get; set; }

    public string? ServiceTypeName { get; set; }

    public string? ServiceTypeCode { get; set; }

    public string? PatientSubName { get; set; }

    public string? DoctorId { get; set; }

    public decimal? DoctorPercent { get; set; }

    public decimal? DoctorAmount { get; set; }

    public string? VoucherType { get; set; }

    public decimal? CreditReceivedAmount { get; set; }

    public DateTime? CreditDueDate { get; set; }

    public decimal SaleReturn { get; set; }

    public decimal? TotalCostAfterSaleReturn { get; set; }

    public string? PatientAge { get; set; }

    public decimal TotalCostBelongToDoctorIncentive { get; set; }

    public string? TechName { get; set; }

    public string? TeechCode { get; set; }

    public string? RadioName { get; set; }

    public string? RadioCode { get; set; }

    public string? TechId { get; set; }

    public decimal? TechPercent { get; set; }

    public decimal? TechAmount { get; set; }

    public decimal? RadioPercent { get; set; }

    public string? RadioId { get; set; }

    public decimal? RadioAmount { get; set; }

    public string? UserName { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? BalanceBeforePaid { get; set; }

    public bool? UseClinicFee { get; set; }

    public string? BranchType { get; set; }

    public string? BranchAddress { get; set; }

    public string? BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? StaffById { get; set; }

    public string? OperatorName { get; set; }

    public decimal? TaxPercent { get; set; }
}
