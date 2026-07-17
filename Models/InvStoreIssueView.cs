using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStoreIssueView
{
    public string IssueId { get; set; } = null!;

    public string? IssueNo { get; set; }

    public string? Mrid { get; set; }

    public DateTime? IssueOn { get; set; }

    public string? IssueStatus { get; set; }

    public string? IssueBy { get; set; }

    public string? LocationId { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? Mrno { get; set; }

    public string? IssuePersonCode { get; set; }

    public string? IssuePersonName { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? LocationName { get; set; }

    public string? LocationCode { get; set; }

    public string? StationId { get; set; }

    public string? StationName { get; set; }
}
