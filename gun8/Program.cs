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

        Invoice invoice = new Invoice(customerName, productName, unitPrice, quantity, 0 );
        InvoiceCalculator.CalculateTotal(invoice);

        Console.WriteLine("Total: " + invoice.Total);

        InvoicePrinter invoicePrinter = new InvoicePrinter();
        invoicePrinter.PrintInvoices(invoice);

        InvoiceFileSaver invoiceFileSaver = new InvoiceFileSaver();
        invoiceFileSaver.SaveToFile(invoice);
    }
}