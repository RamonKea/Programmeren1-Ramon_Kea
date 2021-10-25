using System;
using System.Globalization;
using System.Threading;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // ask the user to enter three numbers
            Console.Write("Enter first number: ");
            string firstInput = Console.ReadLine();
            double firstNumber = double.Parse(firstInput);

            Console.Write("Enter second number: ");
            string secondInput = Console.ReadLine();
            double secondNumber = double.Parse(secondInput);

            Console.Write("Enter third number: ");
            string thirdInput = Console.ReadLine();
            double thirdNumber = double.Parse(thirdInput);

            // calculate the sum of the three numbers and display the outcome
            double sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine("sum = {0}", sum);

            // calculate the average of the three numbers and display the outcome
            double average = (firstNumber + secondNumber + thirdNumber) / 3;
            Console.WriteLine("average = {0:F2}", average);

            // calculate the product of the three numbers and display the outcome
            double product = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine("product = {0}", product);

            // caculate the highest number and display it
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("highest = {0}", firstNumber);
            }
            else
            {
                if (firstNumber < secondNumber && secondNumber > thirdNumber)
                {
                    Console.WriteLine("highest = {0}", secondNumber);
                }
                else
                    if (thirdNumber > secondNumber && firstNumber < thirdNumber)
                {
                    Console.WriteLine("highest = {0}", thirdNumber);
                }
            }

            //calculate the lowest number and display it
            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                Console.WriteLine("lowest = {0}", firstNumber);
            }
            else
            {
                if (firstNumber > secondNumber && secondNumber < thirdNumber)
                {
                    Console.WriteLine("lowest = {0}", secondNumber);
                }
                else
                    if (thirdNumber < secondNumber && firstNumber > thirdNumber)
                {
                    Console.WriteLine("lowest = {0}", thirdNumber);
                }
            }

            Console.ReadKey();
        }
    }
}
