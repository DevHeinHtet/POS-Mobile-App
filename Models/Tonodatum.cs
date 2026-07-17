using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class Tonodatum
{
    public string TonotestId { get; set; } = null!;

    public DateTime? TestOn { get; set; }

    public string? VisitId { get; set; }

    public string? Rfirstmmhg { get; set; }

    public string? Rsecondmmhg { get; set; }

    public string? Ravgmmhg { get; set; }

    public string? Rresult { get; set; }

    public string? Lfirstmmhg { get; set; }

    public string? Lsecondmmhg { get; set; }

    public string? Lavgmmhg { get; set; }

    public string? Lresult { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? Remark { get; set; }
}
