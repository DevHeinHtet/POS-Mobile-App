using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstLocationStaff
{
    public string LocationStaffId { get; set; } = null!;

    public string StaffId { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public bool PrimaryLocation { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
