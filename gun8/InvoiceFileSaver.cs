namespace gun8
{
    class InvoiceFileSaver
    {
        public void SaveToFile(Invoice invoice)
        {
            string path = "invoice.txt";

            InvoicePrinter invoicePrinter = new InvoicePrinter();
            string content =
                invoicePrinter.PrintInvoices(invoice) +
                "\n---------------------------------\n";

            File.AppendAllText(path, content);

            Console.WriteLine("Fatura dosyaya eklendi.");
        }
    }
}
