using CabInvoice;

namespace CabIncoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            invoiceGenerator.calculateFare();
        }
    }
}