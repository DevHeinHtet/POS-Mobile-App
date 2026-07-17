using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstTownship
{
    public string TownshipId { get; set; } = null!;

    public string? TownshipCode { get; set; }

    public string? TownshipName { get; set; }

    public string? CityName { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
