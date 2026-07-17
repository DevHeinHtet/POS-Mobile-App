using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrPatientId
{
    public string PatientIdentifierId { get; set; } = null!;

    public string Idno { get; set; } = null!;

    public string Idtype { get; set; } = null!;

    public DateOnly? ActiveFrom { get; set; }

    public string PatientId { get; set; } = null!;

    public DateOnly? ActiveTo { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
