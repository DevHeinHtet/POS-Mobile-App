using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using POSMobileApp.Data;
using POSMobileApp.Extensions;
using POSMobileApp.ViewModels.Carts;
using POSMobileApp.ViewModels.Categories;
using POSMobileApp.ViewModels.Products;


namespace POSMobileApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        private const string CartSessionKey = "POS_Cart";

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string category = "All")
        {
            var categories = await _context.EmrGenerics.Where(x => x.Active).Select(x => new CategorySummaryVM { Id = x.GenericId, Name = x.GenericName }).ToListAsync();
            ViewBag.Categories = categories;

            TempData["ActiveCategory"] = categories;

            var cart = HttpContext.Session.GetObjectFromJson<CartSummaryVM>(CartSessionKey) ?? new CartSummaryVM();

            TempData["CartItemCount"] = cart.Items.Count;
            TempData["CartTotal"] = cart.Total;

            var productList = await _context.EmrItemViews.Where(x => x.Active).Select(x => new ProductSummaryVM(x.ItemId, x.ItemName, x.ItemNo)).ToListAsync();

            return View(productList);
        }

        [HttpGet]
        public async Task<IActionResult> GetDetail(string id)
        {
            var product = await _context.EmrItems.FirstOrDefaultAsync(x => x.ItemId == id);
            if (product == null) return NotFound();

            var productDetail = new ProductDetailVM
            {
                ProductId = product.ItemId,
                CategoryId = product.GenericId,
                ProductName = product.ItemName,
                Description = product.Remark,
                ProductCode = product.ItemNo,
                ShortCode = product.ShortCode
            };

            var productUnitList = await (
                from unit in _context.EmrItemUoms
                join price in _context.EmrItemPrices
                    on unit.ItemUomid equals price.UnitId into prices
                from price in prices.DefaultIfEmpty()
                where unit.ItemId == id
                select new ProductUnitVM
                {
                    UnitId = unit.ItemUomid,
                    UnitName = unit.UomLabel,
                    UnitPrice = price != null ? price.Price ?? 0 : 0,
                    IsReportUnit = unit.IsReportUnit ?? false
                }
            ).ToListAsync();

            productDetail.ProductUnits = productUnitList;

            var jsonData = JsonConvert.SerializeObject(productDetail);

            return Json(productDetail);
        }
    }
}