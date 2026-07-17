using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrItemPriceView
{
    public string ItemPriceId { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? UnitId { get; set; }

    public decimal? Price { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? UomLabel { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public decimal? OldPrice { get; set; }

    public string? PriceChangeFormula { get; set; }

    public string? PriceChangeFormulaType { get; set; }

    public bool? PriceChangeSign { get; set; }

    public decimal? FormulaAmount { get; set; }

    public decimal? FormulaPercentage { get; set; }

    public string? GenericId { get; set; }
}
