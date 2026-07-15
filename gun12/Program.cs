using gun12;

List<Customer> customers = new List<Customer>
{
    new Customer { Id = 1, Name = "John Doe" },
    new Customer { Id = 2, Name = "Jane Smith" },
    new Customer { Id = 3, Name = "Bob Johnson" },
    new Customer { Id = 4, Name = "Alice Williams" },
    new Customer { Id = 5, Name = "Charlie Brown" }
};

List<Order> orders = new List<Order>
{
    new Order { Id = 1, OrderId = 1, Amount = 100.50m },
    new Order { Id = 2, OrderId = 2, Amount = 200.75m },
    new Order { Id = 3, OrderId = 1, Amount = 150.00m },
    new Order { Id = 4, OrderId = 3, Amount = 300.25m },
    new Order { Id = 5, OrderId = 4, Amount = 250.00m },
    new Order { Id = 1, OrderId = 1, Amount = 100.50m },
    new Order { Id = 2, OrderId = 2, Amount = 100.75m },
    new Order { Id = 3, OrderId = 1, Amount = 10.00m },
    new Order { Id = 3, OrderId = 5, Amount = 10.00m }
};

var customer = from c in customers
               join o in orders on c.Id equals o.Id
               select new { name = c.Name, amount = o.Amount };

foreach (var result in customer)
{
    Console.WriteLine($"Customer: {result.name}, Amount: {result.amount}");
}

decimal TotalAmount = orders.Sum(o => o.Amount);
Console.WriteLine("------------------------------");
Console.WriteLine("Total Amount: " + TotalAmount);

double AverageAmount = orders.Average(o => (double)o.Amount);
Console.WriteLine("------------------------------");
Console.WriteLine("Average Amount: " + AverageAmount);

int orderCount = orders.Count();
Console.WriteLine("------------------------------");
Console.WriteLine("Order Count: " + orderCount);

var expensiveOrders = orders.OrderByDescending(o => o.Amount).First();
Console.WriteLine("------------------------------");
Console.WriteLine("Most Expensive Order: " + expensiveOrders.Amount);

bool hasLargeOrders = orders.Any(o => o.Amount > 500);
Console.WriteLine("------------------------------"); 
Console.WriteLine("Has Large Orders (> 500): " + hasLargeOrders);

var groupedOrders = orders.GroupBy(o => customers.First(c => c.Id == o.Id).Name)
                          .Select(g => new { Name = g.Key, TotalAmount = g.Sum(o => o.Amount) });
foreach (var group in groupedOrders)
{
    Console.WriteLine("------------------------------");
    Console.WriteLine($"Customer: {group.Name}, Total Amount: {group.TotalAmount}");
}