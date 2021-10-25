using System;
using System.Globalization;
using System.Threading;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            double counter = 0;
            double numberInput = 0;
            double TotalSumOfNumberInput = 0;

            // Ask user for a couple of numbers till the number 0 is stated
            do
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                numberInput = double.Parse(input);

                if (numberInput > 0)
                {
                    TotalSumOfNumberInput += numberInput;
                    counter++;
                }
            } while (numberInput != 0);
            
            // Calculate the average of all the numbers
            if (TotalSumOfNumberInput == 0)
            {
                Console.Write("Average of all positive numbers is: 0.00");
            }
            else 
            {
                double average = TotalSumOfNumberInput / counter;
                Console.Write("Average of all positive numbers is: {0:F2}", average);
            }

            Console.ReadKey();
        }
    }
}
