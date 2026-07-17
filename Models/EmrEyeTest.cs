using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrEyeTest
{
    public string EyeTestId { get; set; } = null!;

    public DateTime? TestOn { get; set; }

    public string? VisitId { get; set; }

    public decimal? Lresult { get; set; }

    public decimal? Rresult { get; set; }

    public string? RefNo { get; set; }

    public string? Pd { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? Remark { get; set; }

    public string? Recommand { get; set; }
}
