using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrEyeTestLeftandRightView
{
    public string EyeTestLid { get; set; } = null!;

    public string? EyeTestId { get; set; }

    public string? Distance { get; set; }

    public string Stest { get; set; } = null!;

    public string? Ctest { get; set; }

    public string? Atest { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? Remark { get; set; }

    public string? Type { get; set; }

    public string? Side { get; set; }

    public string? Rstest { get; set; }

    public string? Rctest { get; set; }

    public string? Ratest { get; set; }
}
