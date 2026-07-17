using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrAllergyTypeView
{
    public string AllergyTypeId { get; set; } = null!;

    public string? AllergyTypeName { get; set; }

    public string? Description { get; set; }

    public string? AllergyTypeGroupId { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? AllergyTypeGroupName { get; set; }
}
