using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrRecommendation
{
    public string RecommendationId { get; set; } = null!;

    public string? ParentType { get; set; }

    public string? ParentRecordId { get; set; }

    public string? SecondaryType { get; set; }

    public string? SecondaryItemId { get; set; }

    public string? ItemUnitId { get; set; }

    public string? Level { get; set; }

    public string? RecommendationInfo { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
