namespace gun9
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalPrice);
    }
}
