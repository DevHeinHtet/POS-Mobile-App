using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstBranchView
{
    public string BranchId { get; set; } = null!;

    public string? BranchNo { get; set; }

    public string? BranchName { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? BranchAddress { get; set; }

    public string? BranchPhone { get; set; }

    public string? BranchEmail { get; set; }

    public string? BranchFax { get; set; }

    public string? ImageUrl { get; set; }

    public string? ImageName { get; set; }

    public string? LocationId { get; set; }

    public string? LocationName { get; set; }

    public string? LocationCode { get; set; }

    public string? LocationType { get; set; }
}
