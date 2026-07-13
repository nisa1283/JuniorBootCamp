namespace gun9
{
    public class SeniorDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalPrice)
        {
            return totalPrice * 0.75m;
        }
    }
}
