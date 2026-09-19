using Microsoft.EntityFrameworkCore;
using POSMobileApp.Data;
using POSMobileApp.Models;
using POSMobileApp.ViewModels;
using POSMobileApp.ViewModels.Payments;
using System.Globalization;

namespace POSMobileApp.Services.Payments
{
    public class PaymentService : IPaymentService
    {
        private readonly AppDbContext _context;

        public PaymentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<PaymentViewModel>> GetPaymentsDataAsync(string searchText, int page = 1, int pageSize = 15)
        {
            if (page < 1) page = 1;

            var query = _context.EmrPaymentViews.Where(c => c.Active == true);

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                query = query.Where(c =>
                    c.InvoiceNo.Contains(searchText) ||
                    (c.Remark != null && c.Remark.Contains(searchText)));
            }

            var totalCount = await query.CountAsync();

            int calculatedTotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            if (page > calculatedTotalPages && calculatedTotalPages > 0)
            {
                page = calculatedTotalPages;
            }

            var payments = await query
                .OrderByDescending(c => c.CreatedOn)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(row => new PaymentViewModel
                {
                    PaymentId = row.PaymentId,
                    CustomerId = row.PatientId,
                    PaymentAmount = row.PaymentAmount,
                    PaymentDate = row.PaymentDate,
                    CurrencyExchangeCode = row.CurrencyExchangeCode,
                    CurrencyExchangeId = row.CurrencyExchangeId,
                    VisitId = row.VisitId,
                    InvoiceId = row.InvoiceId,
                    Remark = row.Remark,
                    CreatedOn = row.CreatedOn
                })
                .ToListAsync();

            return new PagedResult<PaymentViewModel>
            {
                Items = payments,
                TotalCount = totalCount,
                CurrentPage = page,
                TotalPages = calculatedTotalPages
            };
        }

        public async Task<(bool Success, string Message, string? PaymentId)> SavePaymentAsync(SavePaymentRequest request)
        {
            // Basic validations
            if (string.IsNullOrWhiteSpace(request.UserId))
                return (false, "User ID is required.", null);

            if (string.IsNullOrWhiteSpace(request.InvoiceId))
                return (false, "Invoice ID is required.", null);

            if (!decimal.TryParse(
                    request.Amount,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out decimal invoicePayment))
            {
                return (false, "Invalid payment amount.", null);
            }

            // Fetch invoice
            var invoice = await _context.EmrInvoices
                .FirstOrDefaultAsync(
                    x => x.InvoiceId == request.InvoiceId && x.Active == true);

            if (invoice == null)
                return (false, "Invoice not found.", null);

            if (invoice.Status == "Completed")
                return (false, "Voucher has been completed.", null);

            // Get existing payments
            var totalPayment = await _context.EmrPayments
                .Where(x =>
                    x.InvoiceId == request.InvoiceId &&
                    x.PaymentId != request.PaymentId &&
                    x.Active == true)
                .SumAsync(x => (decimal?)x.PaymentAmount) ?? 0;

            // Calculate invoice total
            var invoiceTotal =
                (invoice.TotalCost ?? 0)
                + (invoice.TaxAmount ?? 0)
                - (invoice.TotalDiscount ?? 0)
                + (invoice.Other1Amount ?? 0)
                + (invoice.Other2Amount ?? 0)
                - (/*invoice.LuckDrawAmount ??*/ 0);

            if (invoiceTotal < invoicePayment + totalPayment)
                return (false, "Total Payment is more than Voucher Remaining Balance.", null);

            // Parse date
            if (!DateTime.TryParseExact(
                    request.PaymentOn,
                    "yyyy/MM/dd hh:mm:ss tt",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime paymentDate))
            {
                return (false, "Invalid payment date. Expected format: yyyy/MM/dd hh:mm:ss tt", null);
            }

            EmrPayment payment;

            // CREATE
            if (string.IsNullOrWhiteSpace(request.PaymentId))
            {
                payment = new EmrPayment
                {
                    PaymentId = Guid.NewGuid().ToString(),
                    CreatedBy = request.UserId,
                    CreatedOn = DateTime.Now,
                    Active = true,
                    PaymentAmount = 0,
                    LastAction = Guid.NewGuid().ToString()
                };

                await _context.EmrPayments.AddAsync(payment);
            }
            // UPDATE
            else
            {
                payment = await _context.EmrPayments
                    .FirstOrDefaultAsync(
                        x => x.PaymentId == request.PaymentId);

                if (payment == null)
                    return (false, "System cannot find the payment record.", null);
            }

            // Set properties
            payment.ModifiedBy = request.UserId;
            payment.ModifiedOn = DateTime.Now;
            payment.LastAction = Guid.NewGuid().ToString();
            payment.InvoiceId = request.InvoiceId;
            payment.PaymentDate = paymentDate;
            payment.Remark = request.Remark == "undefined" ? "" : request.Remark;
            payment.PaymentAmount = invoicePayment;
            payment.CurrencyExchangeId = request.Currency;

            await _context.SaveChangesAsync();

            // Recalculate invoice amount
            await CalculateInvoiceAmount(payment.InvoiceId);

            return (true, "Payment saved successfully.", payment.PaymentId);
        }

        private async Task CalculateInvoiceAmount(
                string invoiceId)
        {
            // Get all active payments for the invoice
            var paymentAmount = await _context.EmrPayments
                .Where(x =>
                    x.InvoiceId == invoiceId &&
                    x.Active == true)
                .SumAsync(
                    x => (decimal?)x.PaymentAmount)
                ?? 0;

            // Get invoice
            var invoice = await _context.EmrInvoices
                .FirstOrDefaultAsync(
                    x =>
                        x.InvoiceId == invoiceId &&
                        x.Active == true);

            if (invoice == null)
                return;

            // Update total payment
            invoice.InvoicePayment = paymentAmount;

            // Calculate balance handling null values safely
            invoice.Balance =
                (invoice.TotalCost ?? 0)
                - (invoice.TotalDiscount ?? 0)
                + (invoice.TaxAmount ?? 0)
                + (invoice.Other1Amount ?? 0)
                + (invoice.Other2Amount ?? 0)
                - (invoice.InvoicePayment ?? 0)
                - (/*invoice.LuckDrawAmount ??*/ 0);

            await _context.SaveChangesAsync();
        }
    }
}
