using System.ComponentModel.DataAnnotations;

namespace POSMobileApp.ViewModels.Products
{
    public class ProductDetailViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string ShortCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public List<ProductUnitViewModel> Details { get; set; } = new List<ProductUnitViewModel>();
    }

    public class ProductUnitViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal DisplayOrder { get; set; }
    }

    public class UpdatePricesRequestVM
    {
        public string ProductId { get; set; } = string.Empty;
        public List<UnitPriceUpdateVM> Units { get; set; } = new List<UnitPriceUpdateVM>();
    }

    public class UnitPriceUpdateVM
    {
        public string UnitId { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
