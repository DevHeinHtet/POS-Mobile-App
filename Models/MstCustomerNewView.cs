using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstCustomerNewView
{
    public string CustomerId { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string? Email { get; set; }

    public string? ContactInfo { get; set; }

    public bool Active { get; set; }

    public string? ContactPerson { get; set; }

    public decimal? CreditLimit { get; set; }
}
