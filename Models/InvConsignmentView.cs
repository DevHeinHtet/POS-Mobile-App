using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvConsignmentView
{
    public string Csid { get; set; } = null!;

    public string? Csno { get; set; }

    public DateTime? Date { get; set; }

    public string? Remark { get; set; }

    public string? Terms { get; set; }

    public string? SupplierId { get; set; }

    public string? StoreId { get; set; }

    public string? Status { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? LocationName { get; set; }

    public string? SupplierName { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }
}
