using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POSMobileApp.Data;
using POSMobileApp.Extensions;
using POSMobileApp.ViewModels.Carts;

namespace POSMobileApp.Controllers
{
    public class CartsController : Controller
    {
        private readonly AppDbContext _context;
        private const string CartSessionKey = "POS_Cart";

        public CartsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody] CartItemVM incomingItem)
        {
            if (incomingItem == null || string.IsNullOrEmpty(incomingItem.ProductId))
                return BadRequest("Invalid product selection parameters.");

            var product = await _context.EmrItems.FirstOrDefaultAsync(x => x.ItemId == incomingItem.ProductId);
            if (product == null) return NotFound("Target product missing.");

            var cart = HttpContext.Session.GetObjectFromJson<CartSummaryVM>(CartSessionKey) ?? new CartSummaryVM();
            var existingItem = cart.Items.FirstOrDefault(i => i.ProductId == incomingItem.ProductId && i.UnitId == incomingItem.UnitId && i.UnitPrice == incomingItem.UnitPrice);

            if (existingItem != null)
            {
                existingItem.Quantity += incomingItem.Quantity;
            }
            else
            {
                incomingItem.ProductName = product.ItemName;
                cart.Items.Add(incomingItem);
            }

            HttpContext.Session.SetObjectAsJson(CartSessionKey, cart);

            return ViewComponent("CartItemsList");
        }

        [HttpPost]
        public IActionResult UpdateCartItem([FromBody] UpdateCartItemRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.ProductId))
                return BadRequest("Invalid request parameters.");

            var cart = HttpContext.Session.GetObjectFromJson<CartSummaryVM>(CartSessionKey) ?? new CartSummaryVM();
            var item = cart.Items.FirstOrDefault(i => i.ProductId == request.ProductId && i.UnitId == request.UnitId && i.UnitPrice == request.UnitPrice);

            if (item != null)
            {
                if (request.Quantity.HasValue) item.Quantity = request.Quantity.Value;
                if (request.UnitPrice.HasValue) item.UnitPrice = request.UnitPrice.Value;

                if (item.Quantity <= 0)
                {
                    cart.Items.Remove(item);
                }

                HttpContext.Session.SetObjectAsJson(CartSessionKey, cart);
            }

            return ViewComponent("CartItemsList");
        }

        [HttpPost]
        public IActionResult RemoveFromCart([FromBody] RemoveCartItemRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.ProductId))
                return BadRequest("Invalid item specifications.");

            var cart = HttpContext.Session.GetObjectFromJson<CartSummaryVM>(CartSessionKey) ?? new CartSummaryVM();
            var itemToRemove = cart.Items.FirstOrDefault(i => i.ProductId == request.ProductId && i.UnitId == request.UnitId);

            if (itemToRemove != null)
            {
                cart.Items.Remove(itemToRemove);
                HttpContext.Session.SetObjectAsJson(CartSessionKey, cart);
            }

            return ViewComponent("CartItemsList");
        }
    }

    public class UpdateCartItemRequest
    {
        public string ProductId { get; set; }
        public string UnitId { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
    }

    public class RemoveCartItemRequest
    {
        public string ProductId { get; set; }
        public string UnitId { get; set; }
    }
}
