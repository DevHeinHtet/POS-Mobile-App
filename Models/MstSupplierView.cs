using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstSupplierView
{
    public string SupplierId { get; set; } = null!;

    public string SupplierCode { get; set; } = null!;

    public string SupplierName { get; set; } = null!;

    public string? Email { get; set; }

    public string? ContactInfo { get; set; }

    public string? ContactPerson { get; set; }

    public string? Source { get; set; }

    public DateOnly? StartDate { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public bool? IsCs { get; set; }

    public string? CsNo { get; set; }
}
