using POSMobileApp.ViewModels;

namespace POSMobileApp.Services.Customers
{
    public interface ICustomerService
    {
        Task<IEnumerable<DropdownViewModel>> GetDropdownDataAsync();
    }
}