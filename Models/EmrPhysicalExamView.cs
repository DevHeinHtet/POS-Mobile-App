using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrPhysicalExamView
{
    public string PhysicalExamId { get; set; } = null!;

    public string? VisitId { get; set; }

    public DateTime? ExamOn { get; set; }

    public string? ExamDescription { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? VisitNo { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? PatientId { get; set; }
}
