using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrItemBarcodeView
{
    public string ItemBarcodeId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string BarcodeNo { get; set; } = null!;

    public string Uomid { get; set; } = null!;

    public string? Remark { get; set; }

    public string? Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItemNo { get; set; }

    public string? UomLabel { get; set; }

    public bool? Active { get; set; }
}
