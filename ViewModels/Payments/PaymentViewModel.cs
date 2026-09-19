namespace POSMobileApp.ViewModels.Payments
{
    public class PaymentViewModel
    {
        public string PaymentId { get; set; }
        public string CustomerId { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CurrencyExchangeCode { get; set; }
        public string CurrencyExchangeId { get; set; }
        public string VisitId { get; set; }
        public string InvoiceId { get; set; }
        public string Remark { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
