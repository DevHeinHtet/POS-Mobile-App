using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class EmrLuckyExpensePurchase
{
    public Guid LuckyExpenseId { get; set; }

    public Guid PurchaseDetailId { get; set; }

    public int Qty { get; set; }
}
