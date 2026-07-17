using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvAdjustmentView
{
    public string AdjustmentId { get; set; } = null!;

    public string AdjustmentNo { get; set; } = null!;

    public DateTime AdjustmentDate { get; set; }

    public string LocationId { get; set; } = null!;

    public string Remark { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? LocationCode { get; set; }

    public string? LocationName { get; set; }
}
