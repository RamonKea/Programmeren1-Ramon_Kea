using System;
using System.Globalization;
using System.Threading;

namespace assignment1
{
    class Program
    {
        const float VAT = 21;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // Ask user to enter a price
            Console.Write("Enter a price: ");
            string input = Console.ReadLine();

            // Use a seperate method to determine the 21% VAT on the price
            float price = float.Parse(input);
            

            // Calculate the price + VAT.
            double priceWithVAT = price + CalcVATPrice(price);

            // Display price, VAT and the price + VAT
            Console.Write("price: {0:F2}, VAT: {1:F2}, total: {2:F2}", price, CalcVATPrice(price), priceWithVAT);

            Console.ReadKey();
        }

        // subprogram to determine 21% VAT of the price
        static float CalcVATPrice(float price)
        {
            float vatPrice = price * (VAT / 100);
            return vatPrice;
        }
    }
}
