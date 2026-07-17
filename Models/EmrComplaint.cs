using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrComplaint
{
    public string ComplaintId { get; set; } = null!;

    public string? VisitId { get; set; }

    public DateTime? ComplaintOn { get; set; }

    public string? ComplaintDescription { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
