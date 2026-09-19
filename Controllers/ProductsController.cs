using Microsoft.AspNetCore.Mvc;
using POSMobileApp.Services.Invoices;
using POSMobileApp.Services.Staffs;
using POSMobileApp.ViewModels.Products;

namespace POSMobileApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Categories = await _categoryService.GetAllCategoriesAsync();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsData(string productNameAndCode, string categoryId, int page = 1)
        {
            var result = await _productService.GetProductsDataAsync(productNameAndCode, categoryId, page);

            return Json(new
            {
                items = result.Items,
                totalCount = result.TotalCount,
                currentPage = result.CurrentPage,
                totalPages = result.TotalPages,
                hasPreviousPage = result.HasPreviousPage,
                hasNextPage = result.HasNextPage
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetProductDetail(string id)
        {
            var product = await _productService.GetProductDetailByIdAsync("123123123123");

            if (product == null)
                return Json(new { success = false, message = "Product not found." });

            return Json(product);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUnitPrices([FromBody] UpdatePricesRequestVM model)
        {
            if (model == null || model.Units == null || !model.Units.Any())
                return Json(new { success = false, message = "Invalid price payload." });

            var result = await _productService.UpdateUnitPricesAsync(model);

            if (!result)
                return Json(new { success = false, message = "Failed to update prices. Records not found." });

            return Json(new { success = true, message = "Unit prices updated successfully!" });
        }
    }
}