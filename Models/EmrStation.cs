using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrStation
{
    public string StationId { get; set; } = null!;

    public string? StationName { get; set; }

    public string? Address { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? StationCode { get; set; }

    public string? Remark { get; set; }
}
