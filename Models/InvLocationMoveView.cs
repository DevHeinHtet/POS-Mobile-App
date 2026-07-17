using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvLocationMoveView
{
    public string LocationMoveId { get; set; } = null!;

    public string? MoveNo { get; set; }

    public DateTime? MoveDate { get; set; }

    public string? Status { get; set; }

    public string? LocationIdfrom { get; set; }

    public string? LocationIdto { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? BranchType { get; set; }

    public string? BranchAddress { get; set; }

    public string? BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? FromLocationName { get; set; }

    public string? FromLocationCode { get; set; }

    public string? ToLocationName { get; set; }

    public string? ToLocationCode { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }
}
