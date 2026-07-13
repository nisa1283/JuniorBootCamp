using gun9;

Customer customer = new Customer("Jack", CustomerType.Student, 1000);

IDiscountStrategy strategy;

switch (customer.CustomerType)
{
    case CustomerType.Student:
        strategy = new StudentDiscount();
        break;

    case CustomerType.Senior:
        strategy = new SeniorDiscount();
        break;

    default:
        strategy = new RegularDiscount();
        break;
}

DiscountCalculator calculator = new DiscountCalculator();

decimal total = calculator.Calculate(customer.TotalPrice, strategy);

Console.WriteLine($"Customer: {customer.Name}");
Console.WriteLine($"Type: {customer.CustomerType}");
Console.WriteLine($"Original Price: {customer.TotalPrice}");
Console.WriteLine($"Discount Applied: {customer.TotalPrice - total}");
Console.WriteLine($"Total Price after discount: {total}");
