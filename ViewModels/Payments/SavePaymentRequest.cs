namespace POSMobileApp.ViewModels.Payments
{
    public class SavePaymentRequest
    {
        public string PaymentId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string InvoiceId { get; set; } = string.Empty;
        public string PaymentOn { get; set; } = string.Empty;
        public string Amount { get; set; } = string.Empty;
        public string Remark { get; set; }
        public string Currency { get; set; }
        public string RequestId { get; set; }
    }
}
