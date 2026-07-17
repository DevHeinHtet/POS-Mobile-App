using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrAllergy
{
    public string AllegriesId { get; set; } = null!;

    public string? VisitId { get; set; }

    public DateTime? NoteOn { get; set; }

    public string? AllergyTypeId { get; set; }

    public string? Allergies { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
