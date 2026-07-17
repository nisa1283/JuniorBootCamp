namespace gun13
{
    public class StoreService
    {
        public List<Product> products = new();
        public int AddProduct(Product product)
        {
            if (products.Any(p => p.Name == product.Name))
            {
                throw new InvalidOperationException($"Product '{product.Name}' already exists.");
            }
            products.Add(product);
            return products.Count - 1; // Return the index of the added product
        }

        public int SellProduct(string name, int quantity)
        {
            var product = products.FirstOrDefault(p => p.Name == name);
            if (product == null)
            {
                throw new ProductNotFoundException($"Product '{name}' not found.");
            }
            if (product.Quantity < quantity)
            {
                throw new InvalidOperationException($"Not enough quantity of '{name}' available.");
            }
            else
            {
                products[0].Quantity -= quantity;
                return products[0].Quantity; // Return the remaining quantity after selling
            }
        }

        public void ShowProduct()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Quantity: {product.Quantity}");
            }
        }

        public void FindProduct(string name) 
        {
            var product = products.FirstOrDefault(p => p.Name == name);
            if (product == null)
            {
                throw new ProductNotFoundException($"Product '{name}' not found.");
            }
            else
            {
                Console.WriteLine($"Name: {product.Name}, Quantity: {product.Quantity}");
            }
        }
    }
}
