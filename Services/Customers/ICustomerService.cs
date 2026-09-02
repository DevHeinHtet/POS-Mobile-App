using POSMobileApp.Models;
using POSMobileApp.ViewModels;

namespace POSMobileApp.Services.Customers
{
    public interface ICustomerService
    {
        Task<MstCustomer> GetByIdAsync(string customerId);
        Task<IEnumerable<DropdownViewModel>> GetDropdownDataAsync();
    }
}