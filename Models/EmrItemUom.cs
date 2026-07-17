using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrItemUom
{
    public string ItemUomid { get; set; } = null!;

    public string UomLabel { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal? ShowSeq { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? ItemId { get; set; }

    public bool? Active { get; set; }

    public bool? IsReportUnit { get; set; }
}
