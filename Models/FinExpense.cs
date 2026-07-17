using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinExpense
{
    public string ExpenseId { get; set; } = null!;

    public string? ExpenseCode { get; set; }

    public DateTime? ExpenseOn { get; set; }

    public string? Description { get; set; }

    public string? ExpenseNo { get; set; }

    public string? ExpenseSessionId { get; set; }

    public string? OperatorId { get; set; }

    public string? CustomerId { get; set; }

    public string? SupplierId { get; set; }

    public string? ExpenseStatus { get; set; }

    public string? AdminNote { get; set; }

    public decimal? Seq { get; set; }

    public string? Hashkeys { get; set; }

    public decimal? Amount { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? RefId { get; set; }
}
