using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrVisitView
{
    public string VisitId { get; set; } = null!;

    public string? VisitNo { get; set; }

    public string? PatientId { get; set; }

    public DateTime? VisitOn { get; set; }

    public string? Remark { get; set; }

    public string? Status { get; set; }

    public string? LocationId { get; set; }

    public string VisitType { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? LocationName { get; set; }

    public string? LocationCode { get; set; }

    public string? CustomerCode { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? CustomerName { get; set; }

    public DateOnly? Dob { get; set; }

    public string? ContactPerson { get; set; }

    public string? Address { get; set; }

    public string? OrderId { get; set; }

    public string? ClinicVoucherId { get; set; }

    public string? ClinicVoucherNo { get; set; }

    public string? DoctorId { get; set; }

    public string? SpecialityId { get; set; }

    public string? DoctorName { get; set; }

    public string? SpecialityTitle { get; set; }

    public string? DoctorNo { get; set; }

    public string? EmergencyContact { get; set; }

    public string? ContactInfo { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? InvoiceStatus { get; set; }

    public string? CustomerId { get; set; }
}
