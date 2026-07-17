using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinIncome
{
    public string IncomeId { get; set; } = null!;

    public string IncomeCode { get; set; } = null!;

    public DateTime? IncomeOn { get; set; }

    public string? Description { get; set; }

    public string? IncomeNo { get; set; }

    public string? IncomeSessionId { get; set; }

    public string? OperatorId { get; set; }

    public string? CustomerId { get; set; }

    public string? SupplierId { get; set; }

    public string? IncomeStatus { get; set; }

    public string? AdminNote { get; set; }

    public decimal? Seq { get; set; }

    public string? HashKeys { get; set; }

    public decimal? Amount { get; set; }

    public bool? Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
