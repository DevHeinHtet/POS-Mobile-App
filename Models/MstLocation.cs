using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstLocation
{
    public string LocationId { get; set; } = null!;

    public string? LocationName { get; set; }

    public string? LocationCode { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? LocationType { get; set; }

    public string? LocationGroup { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? BranchId { get; set; }
}
