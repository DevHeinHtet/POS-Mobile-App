using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrSpecialityView
{
    public string SpecialityId { get; set; } = null!;

    public string? SpecialityGroupId { get; set; }

    public string SpecialityTitle { get; set; } = null!;

    public decimal? ShowSeq { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? SpecialityGroupName { get; set; }
}
