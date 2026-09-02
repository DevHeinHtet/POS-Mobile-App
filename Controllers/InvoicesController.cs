using Microsoft.AspNetCore.Mvc;
using POSMobileApp.Data;
using POSMobileApp.Extensions;
using POSMobileApp.Services.Customers;
using POSMobileApp.Services.Invoices;
using POSMobileApp.Services.Staffs;
using POSMobileApp.ViewModels.Carts;
using POSMobileApp.ViewModels.Invoices;
using System.Net.NetworkInformation;

namespace POSMobileApp.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly IStaffService _staffService;
        private readonly IInvoiceService _invoiceService;
        private readonly ICustomerService _customerService;

        private const string CartSessionKey = "POS_Cart";

        public InvoicesController(IStaffService staffService, IInvoiceService invoiceService, ICustomerService customerService)
        {
            _staffService = staffService;
            _invoiceService = invoiceService;
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Customers = await _customerService.GetDropdownDataAsync();
            ViewBag.Staffs = await _staffService.GetDropdownDataAsync();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MakePayment([FromBody] PaymentRequestVM request)
        {
            var cart = HttpContext.Session.GetObjectFromJson<CartSummaryVM>(CartSessionKey);

            if (cart is null || !cart.Items.Any())
                return Json(new { success = false, message = "Your cart is empty or session has expired." });

            var result = await _invoiceService.SaveInvoiceAsync(request, cart);

            if (!result.IsSuccess)
                return Json(new { success = false, message = result.ErrorMessage });

            HttpContext.Session.Remove(CartSessionKey);

            return Json(new { success = true, invoiceId = result.Data, message = "Invoice saved successfully!" });
        }

        [HttpGet]
        public async Task<IActionResult> GetInvoicesData(string invoiceNo, string customerId, string staffId, string status, int page = 1)
        {
            var result = await _invoiceService.GetInvoicesDataAsync(invoiceNo, customerId, staffId, status, page);

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
        public async Task<IActionResult> GetInvoiceDetail(string id)
        {
            var invoice = await _invoiceService.GetInvoiceDetailByIdAsync(id);
            return Json(invoice);
        }
    }
}