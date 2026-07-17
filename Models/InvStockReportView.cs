using System;
using System.Collections.Generic;

namespace POSMobileApp.Models;

public partial class InvStockReportView
{
    public string Id { get; set; } = null!;

    public string? InvoiceItemId { get; set; }

    public string? StockLedgerId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? UnitCost { get; set; }

    public decimal? TotalCost { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsFoc { get; set; }

    public string? UnitId { get; set; }

    public decimal? Cost { get; set; }

    public bool? DiscountPercentage { get; set; }

    public decimal? DiscountValue { get; set; }

    public decimal? Expr1 { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? InvoiceNo { get; set; }

    public string? ItemName { get; set; }

    public string? ItemNo { get; set; }

    public string? VisitId { get; set; }

    public string? ItemUomid { get; set; }

    public string? UomLabel { get; set; }

    public string? CreatedByCode { get; set; }

    public string? ModifiedByCode { get; set; }

    public string? AddedByCode { get; set; }

    public string? ItemGroupType { get; set; }

    public decimal? TotalQty { get; set; }

    public decimal? DefaultUnitQty { get; set; }

    public string? GenericName { get; set; }

    public string? ItemGroupId { get; set; }

    public decimal? Expr2 { get; set; }

    public string? UomcombineLabels { get; set; }

    public string? UomcombineIds { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? UserName { get; set; }

    public decimal? Focqty { get; set; }

    public string? Focunit { get; set; }

    public bool? Expr3 { get; set; }

    public string? Expr4 { get; set; }

    public string? ItemId { get; set; }

    public string? LocationId { get; set; }

    public string? ReferenceType { get; set; }

    public string? ReferenceId { get; set; }

    public string? PoitemId { get; set; }

    public decimal? Expr5 { get; set; }

    public decimal? RemainingQty { get; set; }

    public decimal? Expr6 { get; set; }

    public bool? Expr7 { get; set; }

    public DateTime? Expr8 { get; set; }

    public string? CustomerName { get; set; }
}
