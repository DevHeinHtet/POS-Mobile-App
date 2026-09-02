namespace POSMobileApp.ViewModels.Products
{
    public class ProductItemViewModel
    {
        public int Id { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

    public class ProductListViewModel
    {
        public List<ProductItemViewModel> Products { get; set; } = new();
        public string SearchQuery { get; set; } = string.Empty;
        public string SelectedCategory { get; set; } = string.Empty;

        public int TotalCount => Products.Count;
    }
}
