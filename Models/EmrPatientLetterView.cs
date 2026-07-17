using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrPatientLetterView
{
    public string LetterId { get; set; } = null!;

    public string? VisitiId { get; set; }

    public string? LetterTypeId { get; set; }

    public string? Title { get; set; }

    public string? Body { get; set; }

    public string? Status { get; set; }

    public string? ApprovedById { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public string? ApprovalRemark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string ModifiedByCode { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? VisitNo { get; set; }

    public string? LetterTypeName { get; set; }

    public string? ApprovedByCode { get; set; }
}
