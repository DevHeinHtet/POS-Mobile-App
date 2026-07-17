using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POSMobileApp.Data;
using POSMobileApp.Services.Customers;
using POSMobileApp.Services.Staffs;
using POSMobileApp.ViewModels.Invoices;

namespace POSMobileApp.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICustomerService _customerService;
        private readonly IStaffService _staffService;

        public InvoicesController(AppDbContext context, ICustomerService customerService, IStaffService staffService)
        {
            _context = context;
            _customerService = customerService;
            _staffService = staffService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Customers = await _customerService.GetDropdownDataAsync();
            ViewBag.Staffs = await _staffService.GetDropdownDataAsync();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetInvoicesData(string invoiceNo, string customerId, string staffId, string status, int page = 1)
        {
            if (page < 1) page = 1;
            int pageSize = 15;

            var baseQuery = _context.EmrInvoiceViews.Where(c => c.Active == true);

            if (!string.IsNullOrWhiteSpace(invoiceNo))
                baseQuery = baseQuery.Where(c => c.InvoiceNo.Contains(invoiceNo));

            if (!string.IsNullOrWhiteSpace(customerId))
                baseQuery = baseQuery.Where(c => c.PatientId == customerId);

            if (!string.IsNullOrWhiteSpace(staffId))
                baseQuery = baseQuery.Where(c => c.StaffById == staffId);

            if (!string.IsNullOrWhiteSpace(status))
                baseQuery = baseQuery.Where(c => c.Status == status);

            var totalCount = await baseQuery.CountAsync();

            int calculatedTotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            if (page > calculatedTotalPages && calculatedTotalPages > 0) page = calculatedTotalPages;

            var invoices = await baseQuery
                .OrderByDescending(c => c.InvoiceNo)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(row => new InvoiceViewModel
                {
                    InvoiceId = row.InvoiceId,
                    CustomerId = row.PatientId,
                    CustomerName = row.CustomerName,
                    InvoiceNo = row.InvoiceNo,
                    InvoiceDate = row.InvoiceDate,
                    Status = row.Status,
                    TotalCost = row.TotalCost,
                    Balance = row.Balance,
                    OperatorName = row.OperatorName
                })
                .ToListAsync();

            return Json(new
            {
                items = invoices,
                totalCount = totalCount,
                currentPage = page,
                totalPages = calculatedTotalPages,
                hasPreviousPage = page > 1,
                hasNextPage = page < calculatedTotalPages
            });
        }
    }
}
