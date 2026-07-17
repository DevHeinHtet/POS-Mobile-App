using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrInsurance
{
    public string InsuranceId { get; set; } = null!;

    public string? InsuranceCode { get; set; }

    public string? InsuranceName { get; set; }

    public string? DiscountMedicine { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactInfo { get; set; }

    public string? ContactEmail { get; set; }

    public string? Status { get; set; }

    public string? Remark { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
