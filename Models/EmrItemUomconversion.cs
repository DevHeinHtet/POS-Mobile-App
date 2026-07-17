using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrItemUomconversion
{
    public string? Name { get; set; }

    public string ItemUomcovId { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? FromUom { get; set; }

    public string? ToUom { get; set; }

    public decimal? Conversion { get; set; }

    public string? Status { get; set; }

    public decimal? ShowSeq { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public bool? Active { get; set; }
}
