using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstServiceTypeView
{
    public string ServiceTypeId { get; set; } = null!;

    public string ServiceTypeName { get; set; } = null!;

    public string ServiceTypeCode { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public decimal? Price { get; set; }

    public bool? IsShowInVoucher { get; set; }

    public string? VisitId { get; set; }
}
