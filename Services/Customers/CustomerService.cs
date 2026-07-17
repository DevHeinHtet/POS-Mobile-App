using Microsoft.EntityFrameworkCore;
using POSMobileApp.Data;
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
