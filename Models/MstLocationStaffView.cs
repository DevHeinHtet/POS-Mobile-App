using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstLocationStaffView
{
    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string LocationStaffId { get; set; } = null!;

    public string StaffId { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public string? StaffCode { get; set; }

    public string? StaffName { get; set; }

    public string? LocationName { get; set; }

    public string? LocationCode { get; set; }

    public string? LocationType { get; set; }

    public string? LocationGroup { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }
}
