using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrPatientOtherName
{
    public string PatientOtherNameId { get; set; } = null!;

    public string? Title { get; set; }

    public string PatientId { get; set; } = null!;

    public string AliasType { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
