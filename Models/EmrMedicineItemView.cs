using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrMedicineItemView
{
    public string MedicineItemId { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? UnitId { get; set; }

    public string? VisitId { get; set; }

    public decimal? Qty { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? VisitNo { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public string? UomLabel { get; set; }

    public string? ItemUomid { get; set; }

    public string? Description { get; set; }

    public string? GenericName { get; set; }

    public string? ItemGroupId { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }

    public string? StockCheckRemark { get; set; }

    public string? DosageRemark { get; set; }
}
