using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class SysUserView
{
    public string UserId { get; set; } = null!;

    public string UserCode { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public DateTime LastLogin { get; set; }

    public string Password { get; set; } = null!;

    public string? Note { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public bool? EnableTouch { get; set; }

    public string? CreatedByCode { get; set; }

    public string? CreatedByName { get; set; }

    public string? ModifedByCode { get; set; }

    public string? ModifiedByName { get; set; }

    public string DepartmentId { get; set; } = null!;

    public string? LandingPage { get; set; }

    public bool? AllowArrival { get; set; }

    public bool? AllowBlackList { get; set; }

    public bool? AllowDeparture { get; set; }

    public bool? AllowInterpol { get; set; }

    public bool? AllowCenter { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DepartmentName { get; set; }

    public string? RoleId { get; set; }

    public string? RoleName { get; set; }

    public string? Email { get; set; }

    public string? PositionName { get; set; }

    public string? PositionId { get; set; }

    public string? StationId { get; set; }

    public string Expr1 { get; set; } = null!;

    public bool? IsLogIn { get; set; }

    public string? DeviceType { get; set; }

    public string? DeviceName { get; set; }
}
