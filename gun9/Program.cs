using gun9;

Customer customer = new Customer("John Doe", "Student", 100m);
DiscountCalculator discountCalculator = new DiscountCalculator();
discountCalculator.CalculateDiscount(customer);
Console.WriteLine($"Customer: {customer.Name}, Type: {customer.CustomerType}, Total Price after discount: {customer.TotalPrice}");