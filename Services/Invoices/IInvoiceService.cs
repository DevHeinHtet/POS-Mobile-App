using POSMobileApp.ViewModels;
using POSMobileApp.ViewModels.Carts;
using POSMobileApp.ViewModels.Invoices;
using POSMobileApp.ViewModels.Products;

namespace POSMobileApp.Services.Invoices
{
    public interface IInvoiceService
    {
        Task<PagedResult<InvoiceViewModel>> GetInvoicesDataAsync(string invoiceNo, string customerId, string staffId, string status, int page = 1, int pageSize = 15);
        Task<InvoiceDetailViewModel> GetInvoiceDetailByIdAsync(string invoiceId);
        Task<OperationResult<string>> SaveInvoiceAsync(PaymentRequestVM paymentRequest, CartSummaryVM cartSummary);
    }
}
