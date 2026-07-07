using gun8;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Please enter your billing information.");
        Console.WriteLine("Please enter your name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Please enter the product name:");
        string productName = Console.ReadLine();

        Console.WriteLine("Please enter the unit price:");
        decimal unitPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the quantity:");
        decimal quantity = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the total:");
        decimal total = Convert.ToDecimal(Console.ReadLine());

        Invoice invoice = new Invoice(customerName, productName, unitPrice, quantity, total);
        InvoiceService.CalculateTotal(invoice);

        InvoiceService invoiceService = new InvoiceService();
        invoiceService.PrintInvoices(invoice);
        invoiceService.SaveToFile(invoice);
    }
}