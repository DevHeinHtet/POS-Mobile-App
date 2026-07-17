using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstItemGroupView
{
    public string ItemGroupId { get; set; } = null!;

    public string ItemGroupName { get; set; } = null!;

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? ImageId { get; set; }

    public int? ParentTypeSeq { get; set; }

    public string? ParentTypeName { get; set; }

    public string? Title { get; set; }

    public bool? IsParent { get; set; }

    public int? Seq { get; set; }

    public string? ParentId { get; set; }

    public int? TypeSeq { get; set; }

    public string? StockType { get; set; }

    public string? ItemGroupCode { get; set; }

    public string? ItemGroupType { get; set; }
}
