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

            int number = 0;
            double average = 0;
            double difference = 0;
            double sumOfRandomNumbers = 0;

            // creates 20 random numbers between 0 and 200 and display them and fill in an array with the random numbers
            Random random = new Random();
            int[] element = new int[20];
            for (int i = 0; i < element.Length; i++)
            {
                int randomNumber = random.Next(0, 201);
                Console.WriteLine("Element {0} is {1}", number, randomNumber);
                sumOfRandomNumbers += randomNumber;
                number++;
                element[i] = randomNumber;
            }

                // Calculate the average and display it.
                average = sumOfRandomNumbers / number;
            Console.WriteLine("\nThe average is: {0:F2}\n", average);

            // Calculate the difference between average and element
            for (int i = 0; i < element.Length; i++)
            {
                difference = element[i] - average;
                Console.WriteLine("Difference between average and element {0} is {1:F2}", i, Math.Abs(difference));
            }

            Console.ReadKey();
        }
    }
}
