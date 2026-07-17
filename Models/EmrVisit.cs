using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrVisit
{
    public string VisitId { get; set; } = null!;

    public string? VisitNo { get; set; }

    public string? PatientId { get; set; }

    public DateTime? VisitOn { get; set; }

    public string? Remark { get; set; }

    public string? Status { get; set; }

    public string? LocationId { get; set; }

    public string? DoctorId { get; set; }

    public string? SpecialityId { get; set; }

    public string VisitType { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
