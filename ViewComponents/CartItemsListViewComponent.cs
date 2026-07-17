using Microsoft.AspNetCore.Mvc;
using POSMobileApp.Extensions;
using POSMobileApp.ViewModels.Carts;

namespace POSMobileApp.ViewComponents
{
    public class CartItemsListViewComponent : ViewComponent
    {
        private const string CartSessionKey = "POS_Cart";

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cart = HttpContext.Session.GetObjectFromJson<CartSummaryVM>(CartSessionKey) ?? new CartSummaryVM();
            return View(cart);
        }
    }
}
