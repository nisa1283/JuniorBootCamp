namespace gun9
{
    public class Customer
    {
        public string Name { get; set; }
        public CustomerType CustomerType { get; set; }
        public decimal TotalPrice { get; set; }

        public Customer(string name, CustomerType customerType, decimal totalPrice)
        {
            Name = name;
            CustomerType = customerType;
            TotalPrice = totalPrice;
        }
    }
}
