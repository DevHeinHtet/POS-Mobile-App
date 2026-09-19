using Microsoft.AspNetCore.Mvc;
using POSMobileApp.Services.Payments;
using POSMobileApp.ViewModels.Payments;

namespace POSMobileApp.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("SearchAllPayment")]
        public async Task<IActionResult> SearchAllPayment(
            string searchText,
            int page = 1,
            int pageSize = 10)
        {
            var result = await _paymentService.GetPaymentsDataAsync(searchText, page, pageSize);

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

        [HttpPost]
        public async Task<IActionResult> SavePayment(
            [FromBody] SavePaymentRequest request)
        {
            if (request == null)
                return Json(new { success = false, message = "Invalid payment payload." });

            try
            {
                var (success, message, paymentId) = await _paymentService.SavePaymentAsync(request);

                if (!success)
                    return Json(new { success = false, message });

                return Json(new
                {
                    success = true,
                    message,
                    paymentId
                });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
