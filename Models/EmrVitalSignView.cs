using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrVitalSignView
{
    public string VitalSignId { get; set; } = null!;

    public string? VisitId { get; set; }

    public string? Weight { get; set; }

    public string? Height { get; set; }

    public string? Bmi { get; set; }

    public string? Bsa { get; set; }

    public string? Temperature { get; set; }

    public string? Pulse { get; set; }

    public string? Respiratory { get; set; }

    public string? Systolic { get; set; }

    public string? Diastolic { get; set; }

    public string? Waist { get; set; }

    public string? Oxygen { get; set; }

    public string? Pain { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? VisitNo { get; set; }

    public string? VisitStatus { get; set; }

    public string VisitType { get; set; } = null!;

    public string? Status { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerCode { get; set; }

    public string? PatientId { get; set; }

    public string? OrderId { get; set; }

    public string? ClinicVoucherId { get; set; }

    public DateOnly? Dob { get; set; }

    public DateTime? VitalSignOn { get; set; }

    public string? ShortIndex { get; set; }

    public string? MeanArterialPressure { get; set; }

    public string? PulsePressure { get; set; }
}
