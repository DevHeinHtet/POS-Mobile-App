using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstStaff
{
    public string StaffId { get; set; } = null!;

    public string StaffCode { get; set; } = null!;

    public string StaffName { get; set; } = null!;

    public string ContactNo { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Department { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? UserId { get; set; }

    public string? BranchId { get; set; }

    public string? SessionNote { get; set; }

    public string? Email { get; set; }

    public string? LocationId { get; set; }
}
