using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrLabResult
{
    public string ResultId { get; set; } = null!;

    public string? ItemId { get; set; }

    public string? InvoiceId { get; set; }

    public string? Result { get; set; }

    public string? Reference { get; set; }

    public string? Unit { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? InvoiceItemId { get; set; }

    public bool? IsNotDoctorIncentive { get; set; }
}
