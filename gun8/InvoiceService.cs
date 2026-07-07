using System.IO;

namespace gun8
{
    public class InvoiceService 
    {    
        public static decimal CalculateTotal(Invoice invoice) 
        {
            invoice.Total = invoice.UnitPrice * invoice.Quantity;
            return invoice.Total;
        }

        public string PrintInvoices(Invoice invoice) 
        {
            string result = "------ FATURA ------\n" +
                            "Müşteri: " + invoice.CustomerName + "\n" +
                            "Ürün: " + invoice.ProductName + "\n" +
                            "Adet: " + invoice.Quantity + "\n" +
                            "Fiyat: " + invoice.UnitPrice + "\n" +
                            "Toplam: " + invoice.Total + "\n";
            Console.Write(result);
            return result;
        }

        public void SaveToFile(Invoice invoice) 
        {
            string path = "invoice.txt";

            string content =
                PrintInvoices(invoice) +
                "\n---------------------------------\n";

            File.AppendAllText(path, content);

            Console.WriteLine("Fatura dosyaya eklendi.");
        }
    }
}
