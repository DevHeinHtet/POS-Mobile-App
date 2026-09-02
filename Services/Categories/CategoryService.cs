using Microsoft.EntityFrameworkCore;
using POSMobileApp.Data;
using POSMobileApp.ViewModels.Categories;

namespace POSMobileApp.Services.Staffs
{
    internal class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategorySummaryVM>> GetAllCategoriesAsync()
        {
            return await _context.EmrGenerics
                .Where(x => x.Active)
                .Select(x => new CategorySummaryVM
                {
                    Id = x.GenericId,
                    Name = x.GenericName
                })
                .ToListAsync();
        }
    }
}
