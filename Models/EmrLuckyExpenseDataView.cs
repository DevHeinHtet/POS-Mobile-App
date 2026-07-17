using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrLuckyExpenseDataView
{
    public Guid Id { get; set; }

    public string? LuckyId { get; set; }

    public string? InvoiceId { get; set; }

    public string? InvoiceNo { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal Charges { get; set; }

    public int Qty { get; set; }

    public int CurrentQty { get; set; }

    public string Type { get; set; } = null!;
}
