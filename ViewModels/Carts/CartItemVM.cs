namespace POSMobileApp.ViewModels.Carts
{
    public class CartSummaryVM
    {
        public List<CartItemVM> Items { get; set; } = new List<CartItemVM>();
        public decimal Subtotal => Items.Sum(i => i.TotalPrice);
        public decimal Tax => Subtotal * 0.0m;
        public decimal Total => Subtotal + Tax;
        public int TotalItems => Items.Sum(i => i.Quantity);
    }

    public class CartItemVM
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => UnitPrice * Quantity;
    }
}