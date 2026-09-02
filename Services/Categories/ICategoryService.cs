using POSMobileApp.ViewModels;
using POSMobileApp.ViewModels.Categories;

namespace POSMobileApp.Services.Staffs
{
    public interface ICategoryService
    {
        Task<List<CategorySummaryVM>> GetAllCategoriesAsync();
    }
}
