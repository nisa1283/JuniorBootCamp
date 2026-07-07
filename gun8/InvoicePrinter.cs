namespace gun8
{
    class InvoicePrinter
    {
        public string PrintInvoices(Invoice invoice)
        {
            string result = "------ FATURA ------\n" +
                            "Müşteri: " + invoice.CustomerName + "\n" +
                            "Ürün: " + invoice.ProductName + "\n" +
                            "Adet: " + invoice.Quantity + "\n" +
                            "Fiyat: " + invoice.UnitPrice + "\n" +
                            "Toplam: " + invoice.Total + "\n";
            return result;
        }
    }
}
