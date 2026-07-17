using POSMobileApp.ViewModels;

namespace POSMobileApp.Services.Staffs
{
    public interface IStaffService
    {
        Task<IEnumerable<DropdownViewModel>> GetDropdownDataAsync();
    }
}
