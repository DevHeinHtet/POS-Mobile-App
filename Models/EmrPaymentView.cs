using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrPaymentView
{
    public string PaymentId { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public decimal PaymentAmount { get; set; }

    public string? VisitId { get; set; }

    public string? PatientId { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? InvoiceId { get; set; }

    public string? InvoiceNo { get; set; }

    public string? CurrencyExchangeCode { get; set; }

    public string? CurrencyExchangeName { get; set; }

    public string? CurrencyExchangeId { get; set; }
}
