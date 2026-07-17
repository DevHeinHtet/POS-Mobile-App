using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class FinIncomeWeekView
{
    public string IncomeWeekId { get; set; } = null!;

    public string? IncomeId { get; set; }

    public string? WeekName { get; set; }

    public DateOnly StartDay { get; set; }

    public DateOnly EndDay { get; set; }

    public decimal? SaleIncome { get; set; }

    public decimal? CreditReceive { get; set; }

    public decimal? OtherIncome { get; set; }

    public decimal? Total { get; set; }

    public decimal? RealSaleIncome { get; set; }

    public decimal? RealCreditReceive { get; set; }

    public decimal? RealOtherIncome { get; set; }

    public decimal? RealTotal { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }
}
