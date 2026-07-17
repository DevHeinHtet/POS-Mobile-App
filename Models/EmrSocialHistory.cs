using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrSocialHistory
{
    public string SocialHistoryId { get; set; } = null!;

    public string? VisitId { get; set; }

    public DateTime? NoteOn { get; set; }

    public string? SocialHistory { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
