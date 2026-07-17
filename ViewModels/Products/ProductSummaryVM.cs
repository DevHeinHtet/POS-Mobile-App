namespace POSMobileApp.ViewModels.Products
{
    public class ProductSummaryVM
    {
        public string ProductId { get; private set; }
        public string ProductName { get; private set; }
        public string ProductCode { get; private set; }

        public ProductSummaryVM(string productId, string productName, string productCode)
        {
            ProductId = productId;
            ProductName = productName;
            ProductCode = productCode;
        }
    }
}
