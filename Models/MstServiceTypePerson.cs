using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstServiceTypePerson
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

    public string? ServiceTypeId { get; set; }
}
