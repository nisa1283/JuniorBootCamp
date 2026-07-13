namespace gun9
{
    public class Customer
    {
        public string Name { get; set; }
        public string CustomerType { get; set; }
        public decimal TotalPrice { get; set; }

        public Customer(string name, string customerType, decimal totalPrice)
        {
            this.Name = name;
            this.CustomerType = customerType;
            this.TotalPrice = totalPrice;
        }
    }
}
