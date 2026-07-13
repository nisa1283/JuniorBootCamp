namespace gun9
{
    public class DiscountCalculator
    {
        public void CalculateDiscount(Customer customer)
        {
            if (customer.CustomerType == "Student")
            {
                customer.TotalPrice = customer.TotalPrice * 0.8m;
            }
            else if (customer.CustomerType == "Senior")
            {
                customer.TotalPrice = customer.TotalPrice * 0.75m;
            }
            else
            {
                customer.TotalPrice = customer.TotalPrice;
            }
        }
    }
}
