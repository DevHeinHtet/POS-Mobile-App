using POSMobileApp.ViewModels;
using POSMobileApp.ViewModels.Payments;

namespace POSMobileApp.Services.Payments
{
    public interface IPaymentService
    {
        Task<PagedResult<PaymentViewModel>> GetPaymentsDataAsync(string searchText, int page = 1, int pageSize = 15);
        Task<(bool Success, string Message, string? PaymentId)> SavePaymentAsync(SavePaymentRequest request);
    }
}
