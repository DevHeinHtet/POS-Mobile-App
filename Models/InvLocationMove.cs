using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvLocationMove
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
}
