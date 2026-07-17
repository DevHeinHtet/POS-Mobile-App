using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstItemGroup
{
    public string ItemGroupId { get; set; } = null!;

    public string ItemGroupName { get; set; } = null!;

    public string? ImageId { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? ParentId { get; set; }

    public bool? IsParent { get; set; }

    public int? Seq { get; set; }

    public string? StockType { get; set; }

    public string? ItemGroupCode { get; set; }

    public string? ItemGroupType { get; set; }
}
