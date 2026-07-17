using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrInPatientService
{
    public string InPatientServiceId { get; set; } = null!;

    public string? InPatientVoucherId { get; set; }

    public string? ServiceTypeId { get; set; }

    public string? ServiceTypePersonId { get; set; }

    public string? ServiceTypeSubName { get; set; }

    public decimal? Price { get; set; }

    public decimal? Time { get; set; }

    public decimal? Total { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public decimal? ServicePrice { get; set; }

    public bool? IsStfoc { get; set; }

    public bool? IsSpfoc { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? Balance { get; set; }

    public decimal? DiscountAmount { get; set; }
}
