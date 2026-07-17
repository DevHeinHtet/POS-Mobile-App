using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrItemUomconversionView
{
    public string? Name { get; set; }

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

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItemNo { get; set; }

    public string? ToUomlabe { get; set; }

    public string? FromUomlabel { get; set; }

    public bool? Active { get; set; }

    public string ItemUomcovId { get; set; } = null!;

    public string? ToUomid { get; set; }

    public string? FromUomid { get; set; }
}
