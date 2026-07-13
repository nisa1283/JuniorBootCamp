namespace gun9
{
    public class RegularDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalPrice)
        {
            return totalPrice;
        }
    }
}
