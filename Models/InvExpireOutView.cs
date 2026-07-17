using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvExpireOutView
{
    public string ExpireOutId { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? LocationId { get; set; }

    public decimal? OutQty { get; set; }

    public string? RefId { get; set; }

    public string? ExpireInId { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public string? LocationName { get; set; }

    public string? LocationCode { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? RefType { get; set; }

    public string? BatchNo { get; set; }

    public DateTime RefDate { get; set; }
}
