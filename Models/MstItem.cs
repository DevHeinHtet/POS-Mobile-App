using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class MstItem
{
    public string ItemId { get; set; } = null!;

    public string? ItemNo { get; set; }

    public string ItemName { get; set; } = null!;

    public string ItemTypeId { get; set; } = null!;

    public decimal DefaultItemPrice { get; set; }

    public string Remark { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedOn { get; set; }

    public string LastAction { get; set; } = null!;

    public string? ImageId { get; set; }

    public string? ShortCode1 { get; set; }

    public string? ShortCode2 { get; set; }

    public int WarningLevelQuantity { get; set; }

    public string? BarcodeImage { get; set; }

    public bool? NotAvaliable { get; set; }

    public string? StockType { get; set; }

    public bool? IsExpiryDateCheck { get; set; }
}
