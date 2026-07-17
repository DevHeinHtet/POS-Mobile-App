using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinPoview
{
    public string Poid { get; set; } = null!;

    public string Pono { get; set; } = null!;

    public string? InternalPono { get; set; }

    public DateTime Podate { get; set; }

    public DateOnly? CreditDueDate { get; set; }

    public string SupplierId { get; set; } = null!;

    public string? SalePersonId { get; set; }

    public string Status { get; set; } = null!;

    public string? Type { get; set; }

    public decimal TotalItemCost { get; set; }

    public string Other1Title { get; set; } = null!;

    public decimal Other1Amount { get; set; }

    public string Other2Title { get; set; } = null!;

    public decimal Other2Amount { get; set; }

    public string? Currency { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? VoucherPayAmount { get; set; }

    public decimal? CreditPaidAmount { get; set; }

    public decimal Balance { get; set; }

    public string? PaymentStatus { get; set; }

    public string Remark { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? CurrencyExchangeCode { get; set; }

    public string? CurrencyExchangeName { get; set; }

    public decimal? CurrencyExchangeRate { get; set; }

    public string? SupplierCode { get; set; }

    public string? SupplierName { get; set; }

    public decimal? CommercialTax { get; set; }

    public decimal? CommercialTaxPercent { get; set; }

    public decimal? Received { get; set; }

    public decimal? Remain { get; set; }

    public decimal? TotalPoqty { get; set; }

    public string? ApprovedBy { get; set; }

    public string? UserName { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? TotalDiscountPercent { get; set; }

    public decimal? TotalDiscount { get; set; }
}
