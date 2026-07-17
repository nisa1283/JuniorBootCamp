using gun13;

List<Product> products = new List<Product>
{
    new Product("Laptop", 10),
    new Product("Mouse", 5),
    new Product("Keyboard", 0) };

StoreService storeService = new StoreService();

try
{

    foreach (var product in products)
    {
        storeService.AddProduct(product);
    }
    storeService.ShowProduct();
    Console.WriteLine("Selling 3 Laptops...");
    int remainingQuantity = storeService.SellProduct("Laptop", 3);
    Console.WriteLine($"Remaining quantity of Laptop: {remainingQuantity}");
}
catch (ProductNotFoundException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    Console.WriteLine("Finding Mouse...");
    storeService.FindProduct("Mouse");
}
catch (ProductNotFoundException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    Console.WriteLine("Selling 1 Keyboard...");
    int remainingQuantity = storeService.SellProduct("Keyboard", 1);
    Console.WriteLine($"Remaining quantity of Keyboard: {remainingQuantity}");
}
catch (ProductNotFoundException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
    try 
{
    Console.WriteLine("Finding Phone...");
    storeService.FindProduct("Phone");
}
catch (ProductNotFoundException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
