using Microsoft.EntityFrameworkCore;
using POSMobileApp.Data;
using POSMobileApp.Models;
using POSMobileApp.Services.Customers;
using POSMobileApp.ViewModels;
using POSMobileApp.ViewModels.Carts;
using POSMobileApp.ViewModels.Invoices;
using POSMobileApp.ViewModels.Products;

namespace POSMobileApp.Services.Invoices
{
    // 1. Changed from 'internal' to 'public' so Dependency Injection can access it
    public class InvoiceService : IInvoiceService
    {
        private readonly AppDbContext _context;
        private readonly ICustomerService _customerService;

        private const string SystemUserId = "4F2C38AF-2E01-49FA-833A-603B7E216B6E";

        public InvoiceService(AppDbContext context, ICustomerService customerService)
        {
            _context = context;
            _customerService = customerService;
        }

        public async Task<PagedResult<InvoiceViewModel>> GetInvoicesDataAsync(string invoiceNo, string customerId, string staffId, string status, int page = 1, int pageSize = 15)
        {
            if (page < 1) page = 1;

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
            if (page > calculatedTotalPages && calculatedTotalPages > 0)
            {
                page = calculatedTotalPages;
            }

            var invoices = await baseQuery
                .OrderByDescending(c => c.CreatedOn)
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

            return new PagedResult<InvoiceViewModel>
            {
                Items = invoices,
                TotalCount = totalCount,
                CurrentPage = page,
                TotalPages = calculatedTotalPages
            };
        }

        public async Task<InvoiceDetailViewModel> GetInvoiceDetailByIdAsync(string invoiceId)
        {
            return await(
                from invoice in _context.EmrInvoices
                where invoice.InvoiceId == invoiceId
                select new InvoiceDetailViewModel
                {
                    InvoiceId = invoice.InvoiceId,
                    InvoiceNo = invoice.InvoiceNo,
                    CustomerName = invoice.PatientSubName,
                    TotalCost = invoice.TotalCost ?? 0,
                    PaidAmount = invoice.InvoicePayment ?? 0,
                    Status = invoice.Status,
                    InvoiceDate = invoice.InvoiceDate,

                    InvoiceItems = (
                        from item in _context.EmrInvoiceItems
                        join product in _context.EmrItems on item.ItemId equals product.ItemId into products
                        from product in products.DefaultIfEmpty()
                        join unit in _context.EmrItemUoms on item.UnitId equals unit.ItemUomid into units
                        from unit in units.DefaultIfEmpty()
                        where item.InvoiceId == invoice.InvoiceId
                        orderby item.CreatedOn descending
                        select new InvoiceItemDetailViewModel
                        {
                            InvoiceItemId = item.InvoiceItemId,
                            ProductName = product.ItemName,
                            ProductUnit = unit.UomLabel,
                            SalePrice = item.Price ?? 0,
                            TotalQuantity = item.TotalQty ?? 0,
                        }
                    ).ToList()
                })
                .FirstOrDefaultAsync();
        }

        public async Task<OperationResult<string>> SaveInvoiceAsync(PaymentRequestVM paymentRequest, CartSummaryVM cartSummary)
        {
            if (cartSummary?.Items is null || !cartSummary.Items.Any())
                return OperationResult<string>.Failure("Cart is empty or invalid.");

            if (paymentRequest is null || string.IsNullOrWhiteSpace(paymentRequest.CustomerId))
                return OperationResult<string>.Failure("Invalid payment request details.");

            var customer = await _customerService.GetByIdAsync(paymentRequest.CustomerId);
            if (customer is null)
                return OperationResult<string>.Failure($"Customer with ID '{paymentRequest.CustomerId}' was not found.");

            var now = DateTime.Now;
            var invoiceId = Guid.NewGuid().ToString();
            var invoiceNo = $"MBTB-{now:yyMMddHHmm}";

            var newInvoice = new EmrInvoice
            {
                InvoiceId = invoiceId,
                InvoiceNo = invoiceNo,
                PatientId = customer.CustomerId,
                PatientSubName = $"{customer.CustomerName}({customer.ContactPerson})",
                InvoiceDate = now,
                Status = "Completed",
                InvoicePayment = paymentRequest.PaidAmount,
                TotalCost = cartSummary.Total,
                DiscountPercent = 0,
                TotalDiscount = 0,
                Balance = cartSummary.Total - paymentRequest.PaidAmount,
                Other1Amount = 0,
                Other2Amount = 0,
                Active = true,
                CreatedBy = SystemUserId,
                CreatedOn = now,
                ModifiedBy = SystemUserId,
                ModifiedOn = now,
                LastAction = "New",
                VoucherType = "Invoice"
            };

            var invoiceItems = cartSummary.Items.Select(item =>
            {
                var lineTotal = item.Quantity * item.UnitPrice;
                return new EmrInvoiceItem
                {
                    InvoiceItemId = Guid.NewGuid().ToString(),
                    InvoiceId = invoiceId,
                    ItemId = item.ProductId,
                    UnitId = item.UnitId,
                    Price = item.UnitPrice,
                    DefaultUnitQty = item.Quantity,
                    TotalQty = item.Quantity,
                    Cost = lineTotal,
                    DiscountPercentage = false,
                    DiscountValue = 0,
                    TotalCost = lineTotal,
                    AddedBy = SystemUserId,
                    AddedOn = now,
                    Active = true,
                    CreatedBy = SystemUserId,
                    CreatedOn = now,
                    ModifiedBy = SystemUserId,
                    ModifiedOn = now,
                    LastAction = "New",
                    Discount = 0,
                    AddedType = "EMR",
                    Qty = item.Quantity,
                    IsNotDoctorIncentive = false,
                    IsFoc = false
                };
            }).ToList();

            var newFinIncome = new FinIncome
            {
                IncomeId = invoiceId,
                IncomeCode = "INV",
                IncomeOn = now,
                Description = $"Invoice Payment for {invoiceNo}",
                IncomeNo = invoiceNo,
                CustomerId = customer.CustomerId,
                IncomeStatus = "Approved",
                Amount = paymentRequest.PaidAmount,
                Active = true,
                CreatedBy = SystemUserId,
                CreatedOn = now,
                ModifiedBy = SystemUserId,
                ModifiedOn = now,
                LastAction = "New"
            };

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                await _context.EmrInvoices.AddAsync(newInvoice);
                await _context.EmrInvoiceItems.AddRangeAsync(invoiceItems);
                await _context.FinIncomes.AddAsync(newFinIncome);

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return OperationResult<string>.Success(invoiceId);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return OperationResult<string>.Failure($"Database error: {ex.Message}");
            }
        }
    }
}