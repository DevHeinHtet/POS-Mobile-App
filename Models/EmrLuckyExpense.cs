using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrLuckyExpense
{
    public Guid Id { get; set; }

    public Guid? LuckyId { get; set; }

    public string? UnitId { get; set; }

    public string? SaleId { get; set; }

    public Guid? MainId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal Charges { get; set; }

    public int Qty { get; set; }

    public int CurrentQty { get; set; }

    public string Type { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
