using Microsoft.EntityFrameworkCore;
using POSMobileApp.Data;
using POSMobileApp.ViewModels;

namespace POSMobileApp.Services.Staffs
{
    internal class StaffService : IStaffService
    {
        private readonly AppDbContext _context;

        public StaffService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DropdownViewModel>> GetDropdownDataAsync()
        {
            return await _context.MstOperatorViews
               .Where(o => o.Active == true && o.Status == "Active")
               .OrderBy(o => o.OperatorName)
               .Select(o => new DropdownViewModel
               {
                   Key = o.OperatorId,
                   Value = o.OperatorName
               })
               .ToListAsync();
        }
    }
}
