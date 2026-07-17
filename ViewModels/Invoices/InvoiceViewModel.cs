namespace POSMobileApp.ViewModels.Invoices
{
    public class InvoiceViewModel
    {
        public string InvoiceId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string Status { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? Balance { get; set; }
        public string OperatorName { get; set; }
    }
}
