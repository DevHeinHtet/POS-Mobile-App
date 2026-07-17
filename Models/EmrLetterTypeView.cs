using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrLetterTypeView
{
    public string LetterTypeId { get; set; } = null!;

    public string? LetterTypeName { get; set; }

    public string? LetterTitle { get; set; }

    public string? LetterBody { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }
}
