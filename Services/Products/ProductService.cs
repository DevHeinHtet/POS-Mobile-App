using Microsoft.EntityFrameworkCore;
using POSMobileApp.Data;
using POSMobileApp.Services.Customers;
using POSMobileApp.ViewModels;
using POSMobileApp.ViewModels.Products;

namespace POSMobileApp.Services.Invoices
{
    // 1. Changed from 'internal' to 'public' so Dependency Injection can access it
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        private readonly ICustomerService _customerService;

        private const string SystemUserId = "4F2C38AF-2E01-49FA-833A-603B7E216B6E";

        public ProductService(AppDbContext context, ICustomerService customerService)
        {
            _context = context;
            _customerService = customerService;
        }

        public async Task<PagedResult<ProductViewModel>> GetProductsDataAsync(string productOrCode, string categoryId, int page = 1, int pageSize = 15)
        {
            if (page < 1) page = 1;

            var baseQuery = _context.EmrItems.Where(i => i.Active == true);

            if (!string.IsNullOrWhiteSpace(productOrCode))
                baseQuery = baseQuery.Where(i => i.ItemName.Contains(productOrCode) || i.ItemNo.Contains(productOrCode));

            if (!string.IsNullOrWhiteSpace(categoryId))
                baseQuery = baseQuery.Where(i => i.GenericId == categoryId);

            var totalCount = await baseQuery.CountAsync();

            int calculatedTotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            if (page > calculatedTotalPages && calculatedTotalPages > 0)
            {
                page = calculatedTotalPages;
            }

            var products = await (
                from item in baseQuery
                join generic in _context.EmrGenerics on item.GenericId equals generic.GenericId into generics
                from generic in generics.DefaultIfEmpty()
                join unit in _context.EmrItemUoms.Where(u => u.IsReportUnit ?? true) on item.ItemId equals unit.ItemId into units
                from unit in units.DefaultIfEmpty()
                join price in _context.EmrItemPrices on unit.ItemUomid equals price.UnitId into prices
                from price in prices.DefaultIfEmpty()
                orderby item.CreatedOn descending
                select new ProductViewModel
                {
                    Id = item.ItemId,
                    Code = item.ItemNo,
                    Name = item.ItemName,
                    Category = generic != null ? generic.GenericName : string.Empty,
                    DefaultUnit = unit != null ? unit.UomLabel : string.Empty,
                    Price = price != null ? price.Price ?? 0 : 0,
                })
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<ProductViewModel>
            {
                Items = products,
                TotalCount = totalCount,
                CurrentPage = page,
                TotalPages = calculatedTotalPages
            };
        }

        public async Task<ProductDetailViewModel> GetProductDetailByIdAsync(string productId)
        {
            var product = await (
                from item in _context.EmrItems
                where item.ItemId == productId
                select new ProductDetailViewModel
                {
                    Id = item.ItemId.ToString(),
                    Code = item.ItemNo,
                    ShortCode = item.ShortCode,
                    Name = item.ItemName,

                    Category = _context.EmrGenerics
                        .Where(g => g.GenericId == item.GenericId)
                        .Select(g => g.GenericName)
                        .FirstOrDefault() ?? string.Empty,

                    Details = (
                        from price in _context.EmrItemPrices
                        join unit in _context.EmrItemUoms
                            on price.UnitId equals unit.ItemUomid into units
                        from unit in units.DefaultIfEmpty()
                        where price.ItemId == item.ItemId
                        orderby unit.ShowSeq
                        select new ProductUnitViewModel
                        {
                            Id = price.ItemPriceId.ToString(),
                            Name = unit != null ? unit.UomLabel : string.Empty,
                            Price = price.Price ?? 0,
                            DisplayOrder = unit != null ? (unit.ShowSeq ?? 0) : 0
                        }
                    ).ToList()
                })
                .FirstOrDefaultAsync();

            return product;
        }

        public async Task<bool> UpdateUnitPricesAsync(UpdatePricesRequestVM model)
        {
            if (model?.Units == null || !model.Units.Any())
                return false;

            // Extract UnitIds (which hold ItemPriceId values)
            var priceIds = model.Units
                .Where(u => !string.IsNullOrWhiteSpace(u.UnitId))
                .Select(u => u.UnitId)
                .Distinct()
                .ToList();

            if (!priceIds.Any())
                return false;

            // Query EmrItemPrices matching ItemPriceId string representations
            var priceEntities = await _context.EmrItemPrices
                .Where(p => priceIds.Contains(p.ItemPriceId.ToString()))
                .ToListAsync();

            if (!priceEntities.Any())
                return false;

            // Update matched entities with new prices
            foreach (var unitDto in model.Units)
            {
                var priceEntity = priceEntities
                    .FirstOrDefault(p => p.ItemPriceId.ToString() == unitDto.UnitId);

                if (priceEntity != null)
                {
                    priceEntity.Price = unitDto.Price;
                }
            }

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return true;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}