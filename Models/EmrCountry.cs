using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrCountry
{
    public string CountryId { get; set; } = null!;

    public string? CountryName { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CountryCode { get; set; }
}
