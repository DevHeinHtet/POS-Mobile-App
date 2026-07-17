using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrInvoice
{
    public string InvoiceId { get; set; } = null!;

    public string? InvoiceNo { get; set; }

    public string? VisitId { get; set; }

    public string? PatientId { get; set; }

    public string? PatientSubName { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? Status { get; set; }

    public decimal? InvoicePayment { get; set; }

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

    public string? CurrencyExchangeId { get; set; }

    public string? LocationId { get; set; }

    public decimal? Prepaid { get; set; }

    public string? DoctorId { get; set; }

    public decimal? DoctorPercent { get; set; }

    public decimal? DoctorAmount { get; set; }

    public string? VoucherType { get; set; }

    public decimal? CreditReceivedAmount { get; set; }

    public DateTime? CreditDueDate { get; set; }

    public string? PatientAge { get; set; }

    public decimal? TotalCostBelongToDoctorIncentive { get; set; }

    public string? TechId { get; set; }

    public decimal? TechPercent { get; set; }

    public decimal? TechAmount { get; set; }

    public string? RadioId { get; set; }

    public decimal? RadioPercent { get; set; }

    public decimal? RadioAmount { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TaxPercent { get; set; }

    public decimal? BalanceBeforePaid { get; set; }

    public bool? UseClinicFee { get; set; }

    public string? StaffById { get; set; }
}
