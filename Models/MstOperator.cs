using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstOperator
{
    public string OperatorId { get; set; } = null!;

    public string? OperatorCode { get; set; }

    public string? OperatorType { get; set; }

    public string? OperatorName { get; set; }

    public string? Email { get; set; }

    public string? Status { get; set; }

    public string? ContactInfo { get; set; }

    public string? EmergencyContact { get; set; }

    public string? Address { get; set; }

    public string? Title { get; set; }

    public string? Speciality { get; set; }

    public string? Qualification { get; set; }

    public bool? Gender { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? UserId { get; set; }

    public string? BranchId { get; set; }
}
