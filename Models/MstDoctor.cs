using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstDoctor
{
    public string DoctorId { get; set; } = null!;

    public string? DoctorName { get; set; }

    public string? DoctorNameEnglish { get; set; }

    public string? DoctorNo { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? ContactInfo { get; set; }

    public string? EmergencyContact { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Title { get; set; }

    public string? Speciality { get; set; }

    public string? Qualification { get; set; }

    public string? Gender { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? Remark { get; set; }
}
