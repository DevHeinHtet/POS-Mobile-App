using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvMritemView
{
    public string MritemId { get; set; } = null!;

    public string? Mrid { get; set; }

    public string? ItemId { get; set; }

    public decimal? RequestQty { get; set; }

    public decimal? IssueQty { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? LocationId { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? Mrno { get; set; }

    public string? ItemName { get; set; }

    public string? ItemNo { get; set; }

    public string? UnitId { get; set; }

    public string? UomLabel { get; set; }

    public string? GenericName { get; set; }

    public string? GenericId { get; set; }

    public decimal? RemainQty { get; set; }

    public decimal? TotalRemainQty { get; set; }

    public DateTime? Mrdate { get; set; }

    public string? Mrtype { get; set; }

    public string? StationName { get; set; }

    public string? SuperApprovedByUser { get; set; }

    public string? Mrstatus { get; set; }

    public string? AprrovedByUser { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }
}
