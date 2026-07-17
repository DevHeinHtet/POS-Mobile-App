using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrMedicineItem
{
    public string MedicineItemId { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? UnitId { get; set; }

    public string? VisitId { get; set; }

    public decimal? Qty { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public bool Active { get; set; }

    public string? StockCheckRemark { get; set; }

    public string? DosageRemark { get; set; }
}
