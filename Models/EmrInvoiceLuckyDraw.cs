using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrInvoiceLuckyDraw
{
    public string LuckDrawId { get; set; } = null!;

    public string? Remark { get; set; }

    public string InvoiceId { get; set; } = null!;

    public decimal TotalQty { get; set; }

    public decimal Price { get; set; }

    public decimal TotalCost { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
