using POSMobileApp.ViewModels;
using POSMobileApp.ViewModels.Products;

namespace POSMobileApp.Services.Invoices
{
    public interface IProductService
    {
        Task<PagedResult<ProductViewModel>> GetProductsDataAsync(string productOrCode, string categoryId, int page = 1, int pageSize = 15);
        Task<ProductDetailViewModel> GetProductDetailByIdAsync(string productId);
        Task<bool> UpdateUnitPricesAsync(UpdatePricesRequestVM model);
    }
}
