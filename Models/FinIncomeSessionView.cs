using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinIncomeSessionView
{
    public string IncomeSessionId { get; set; } = null!;

    public string IncomeCode { get; set; } = null!;

    public string? SessionTitle { get; set; }

    public string? Description { get; set; }

    public string? AccountCode { get; set; }

    public decimal? Seq { get; set; }

    public string? SearchWord { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }
}
