using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrPatientDetail
{
    public string PatientId { get; set; } = null!;

    public string? PatientNo { get; set; }

    public string? Mrdtype { get; set; }

    public bool? IsVip { get; set; }

    public string? VippatientType { get; set; }

    public bool? IsAnonymous { get; set; }

    public string? Tilte { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? PatientName { get; set; }

    public string? Guardian { get; set; }

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public bool? IsDobapproximate { get; set; }

    public bool? BuddhistDate { get; set; }

    public string? DobDd { get; set; }

    public string? DobMm { get; set; }

    public string? DobYyyy { get; set; }

    public string? BloodGroup { get; set; }

    public string? Nationality { get; set; }

    public string? PreferredLanguage { get; set; }

    public bool? InterpreterRequired { get; set; }

    public string? Occupation { get; set; }

    public string? PatientType { get; set; }

    public string? Religion { get; set; }

    public string? AddressNo { get; set; }

    public string? Building { get; set; }

    public string? Lane { get; set; }

    public string? Road { get; set; }

    public string? Area { get; set; }

    public string? City { get; set; }

    public string? District { get; set; }

    public bool? DistrictEdit { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? ZipCode { get; set; }

    public string? ResidentailPhone { get; set; }

    public string? MobileNo { get; set; }

    public string? Email { get; set; }

    public string? ReceivedHostpitalNews { get; set; }

    public string? NationalId { get; set; }

    public DateTime? AciveFrom { get; set; }

    public DateTime? ActiveTo { get; set; }

    public DateTime? RegistrationOn { get; set; }

    public string? RegisterBy { get; set; }

    public string? LocationId { get; set; }

    public string? RegisterationStatus { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? InsuranceId { get; set; }

    public string? ProfileUrl { get; set; }
}
