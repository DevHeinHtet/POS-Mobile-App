using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStoreIssueItemView
{
    public string IssueItemId { get; set; } = null!;

    public string? IssueId { get; set; }

    public string? ItemId { get; set; }

    public decimal? IssuedQty { get; set; }

    public string? IssueBarcodes { get; set; }

    public string? IssuedUom { get; set; }

    public string? IssueRemarks { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? LocationId { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ItemName { get; set; }

    public decimal? RequestQty { get; set; }

    public string? IssueNo { get; set; }

    public decimal? IssueQty { get; set; }

    public string? UnitId { get; set; }

    public string? ItemUomid { get; set; }

    public string? UomLabel { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemGroupName { get; set; }

    public decimal? StockInHand { get; set; }

    public string? GenericName { get; set; }

    public string? GenericId { get; set; }

    public string? Remark { get; set; }

    public string? RefId { get; set; }

    public decimal? RemainQty { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public decimal? TotalIssueQty { get; set; }

    public decimal? TotalRemainQty { get; set; }

    public DateTime? IssueOn { get; set; }

    public string? IssueStatus { get; set; }

    public string? LocationName { get; set; }

    public string? Mrno { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }

    public string? Mrid { get; set; }
}
