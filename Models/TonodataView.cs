using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class TonodataView
{
    public string TonotestId { get; set; } = null!;

    public string? VisitId { get; set; }

    public string? Rfirstmmhg { get; set; }

    public string? Rsecondmmhg { get; set; }

    public string? Ravgmmhg { get; set; }

    public string? Rresult { get; set; }

    public string? Lfirstmmhg { get; set; }

    public string? Lsecondmmhg { get; set; }

    public string? Lavgmmhg { get; set; }

    public string? Lresult { get; set; }

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

    public string? CustomerName { get; set; }

    public string? CustomerCode { get; set; }

    public string? PatientId { get; set; }

    public string? OrderId { get; set; }

    public string? ClinicVoucherId { get; set; }

    public DateOnly? Dob { get; set; }

    public DateTime? TestOn { get; set; }

    public string? Remark { get; set; }
}
