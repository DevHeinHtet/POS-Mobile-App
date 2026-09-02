using Microsoft.EntityFrameworkCore;
using POSMobileApp.Data;
using POSMobileApp.Models;
using POSMobileApp.ViewModels;

namespace POSMobileApp.Services.Customers
{
    internal class CustomerService : ICustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<MstCustomer> GetByIdAsync(string customerId)
        {
            return await _context.MstCustomers.FirstOrDefaultAsync(x => x.CustomerId == customerId && x.Active);
        }

        public async Task<IEnumerable<DropdownViewModel>> GetDropdownDataAsync()
        {
            return await _context.MstCustomers
               .Where(c => c.Active == true)
               .OrderBy(c => c.CustomerName)
               .Select(c => new DropdownViewModel
               {
                   Key = c.CustomerId,
                   Value = c.CustomerName + "(" + c.ContactPerson + ")"
               })
               .ToListAsync();
        }
    }
}
