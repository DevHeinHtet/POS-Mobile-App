namespace POSMobileApp.ViewModels.Products
{
    public class ProductDetailVM
    {
        public string ProductId { get; set; }
        public string CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public string ShortCode { get; set; }
        public List<ProductUnitVM> ProductUnits { get; set; }
    }

    public class ProductUnitVM
    {
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsReportUnit { get; set; }
    }
}
