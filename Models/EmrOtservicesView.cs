using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrOtservicesView
{
    public string OtserviceId { get; set; } = null!;

    public string? OtvoucherId { get; set; }

    public string? ServiceTypeId { get; set; }

    public string? ServiceTypePersonId { get; set; }

    public string? ServiceTypeSubName { get; set; }

    public decimal? Price { get; set; }

    public decimal? Time { get; set; }

    public decimal? Total { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? OtvoucherNo { get; set; }

    public decimal? PayAmount { get; set; }

    public decimal? Remain { get; set; }

    public string? ServiceSubCateName { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? DepositAmount { get; set; }

    public string? ServiceTypeName { get; set; }

    public string? ServiceTypeCode { get; set; }

    public string? DoctorName { get; set; }

    public string? DoctorNo { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }
}
