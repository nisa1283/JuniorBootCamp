namespace gun9
{
    public class DiscountCalculator
    {
        public decimal Calculate(decimal totalPrice, IDiscountStrategy strategy)
        {
            return strategy.ApplyDiscount(totalPrice);
        }
    }
}
