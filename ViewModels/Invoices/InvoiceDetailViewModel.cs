namespace POSMobileApp.ViewModels.Invoices
{
    public class InvoiceDetailViewModel
    {
        public string InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalCost { get; set; }
        public decimal PaidAmount { get; set; }
        public string Status { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public List<InvoiceItemDetailViewModel> InvoiceItems { get; set; }
    }

    public class InvoiceItemDetailViewModel
    {
        public string InvoiceItemId { get; set; }
        public string ProductName { get; set; }
        public string ProductUnit { get; set; }
        public decimal SalePrice { get; set; }
        public decimal TotalQuantity { get; set; }
    }
}
