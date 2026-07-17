using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvMrview
{
    public string Mrid { get; set; } = null!;

    public string? Mrno { get; set; }

    public DateTime? Mrdate { get; set; }

    public string? Mrtype { get; set; }

    public string? RequestById { get; set; }

    public string? RequestToId { get; set; }

    public string? ApprovedBy { get; set; }

    public string? ApprovedRemark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? ModifiedByCode { get; set; }

    public string? CreatedByCode { get; set; }

    public string? RequestByUser { get; set; }

    public string? RequestToUser { get; set; }

    public string? AprrovedByUser { get; set; }

    public string? Mrstatus { get; set; }

    public string? StatusRemark { get; set; }

    public string? StationName { get; set; }

    public string? StationId { get; set; }

    public string? SuperApprovedBy { get; set; }

    public string? SuperApprovedByUser { get; set; }
}
