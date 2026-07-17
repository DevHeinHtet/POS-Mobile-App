using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstCurrencyExchange
{
    public string CurrencyExchangeId { get; set; } = null!;

    public string? CurrencyExchangeCode { get; set; }

    public string? CurrencyExchangeName { get; set; }

    public decimal? CurrencyExchangeRate { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;
}
