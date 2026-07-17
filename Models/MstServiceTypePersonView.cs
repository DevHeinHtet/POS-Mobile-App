using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstServiceTypePersonView
{
    public string ServiceTypePersonId { get; set; } = null!;

    public string PersonId { get; set; } = null!;

    public decimal Price { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? DoctorName { get; set; }

    public string? ServiceTypeName { get; set; }

    public string? ServiceTypeCode { get; set; }

    public string? DoctorNo { get; set; }

    public string? ServiceTypeId { get; set; }
}
