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

            // Enter two numbers
            Console.Write("Enter first number: ");
            string firstInput = Console.ReadLine();
            int firstNumber = int.Parse(firstInput);

            Console.Write("Enter second number: ");
            string secondInput = Console.ReadLine();
            int secondNumber = int.Parse(secondInput);

            Console.WriteLine();

            // Calculate wich number has the highest and the lowest value
            if (firstNumber > secondNumber)
            {  
                // Display which of the two inputs is the highest and the lowest number
                Console.WriteLine("highest value is: {0}", firstNumber);
                Console.WriteLine("lowest value is: {0}", secondNumber);
            }
            else
            {
                // Display which of the two inputs is the highest and the lowest number
                Console.WriteLine("highest value is: {0}", secondNumber);
                Console.WriteLine("lowest value is: {0}", firstNumber);
            }


            Console.ReadKey();
        }
    }
}
