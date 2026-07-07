namespace gun8
{
    class InvoiceCalculator
    {
        public static decimal CalculateTotal(Invoice invoice)
        {
            invoice.Total = invoice.UnitPrice * invoice.Quantity;
            return invoice.Total;
        }
    }
}
