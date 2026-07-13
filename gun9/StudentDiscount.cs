namespace gun9
{
    public class StudentDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalPrice)
        {
            return totalPrice * 0.8m;
        }
    }
}
