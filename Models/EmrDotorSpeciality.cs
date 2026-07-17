using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrDotorSpeciality
{
    public string DoctorSpecialityId { get; set; } = null!;

    public string? DoctorId { get; set; }

    public string? SpecialityId { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
