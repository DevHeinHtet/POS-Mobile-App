using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrDocComment
{
    public string CommentId { get; set; } = null!;

    public string? VisitId { get; set; }

    public DateTime? CommentOn { get; set; }

    public string? Commnet { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
