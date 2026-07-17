using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstCustomerView
{
    public string CustomerId { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string? Email { get; set; }

    public string? ContactInfo { get; set; }

    public string? ContactPerson { get; set; }

    public string? Source { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Ypl { get; set; }

    public string? Kpl { get; set; }

    public string? Tpl { get; set; }

    public string? Bpl { get; set; }

    public string? Pk { get; set; }

    public string? Kk { get; set; }

    public string? Syk { get; set; }

    public string? Lppl { get; set; }

    public string? Lpyh { get; set; }

    public string? Yhnkak { get; set; }

    public string? Kmas { get; set; }

    public string? Dmk { get; set; }

    public string? Tam { get; set; }

    public string? Jpl { get; set; }

    public string? Lst { get; set; }

    public string? Law { get; set; }

    public string? Lpmk { get; set; }

    public string? Apbm { get; set; }

    public string? Sth { get; set; }

    public string? Gsmk { get; set; }

    public string? Lmpl { get; set; }

    public string? Nrcno { get; set; }

    public string? Occupation { get; set; }

    public bool? Gender { get; set; }

    public decimal? CreditLimit { get; set; }
}
