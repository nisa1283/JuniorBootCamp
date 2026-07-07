namespace gun8
{
    public class Invoice
    {
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }

        public Invoice(string customerName, string productName, decimal unitPrice, decimal quantity , decimal total)
        {
            this.CustomerName = customerName;
            this.ProductName = productName;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.Total = total;
        }
    }
}
