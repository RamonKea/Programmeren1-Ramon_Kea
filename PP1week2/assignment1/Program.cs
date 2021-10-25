using System;
using System.Globalization;
using System.Threading;

namespace assingment1
{
    class Program
    {
        const double vat = 0.21;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // 1.Read the price of the product without VAT.
            Console.Write("Enter a price: ");
            string input = Console.ReadLine();

            // Convert string to double (data type conversion)
            double price = double.Parse(input);

            // 2.Calculate the VAT (21%) on this price in euro's.
            double vatprice = price * vat;

            // 3.Calculate the price + VAT.
            double pricewithvat = price + vatprice;

            // 4.Display the price, the VAT and VAT + price
            Console.Write("price: {0:F2}, VAT: {1:F2}, total: {2:F2}", price, vatprice, pricewithvat);
            Console.ReadKey();
        }
    }
}