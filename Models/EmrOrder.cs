using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrOrder
{
    public string OrderId { get; set; } = null!;

    public string? PatientId { get; set; }

    public string? OrderNo { get; set; }

    public DateTime? StartOn { get; set; }

    public string? OrderStatus { get; set; }

    public string? ReferenceType { get; set; }

    public string? ReferenceId { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? StaffName { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? LocationIdfrom { get; set; }

    public string? LocationIdto { get; set; }
}
