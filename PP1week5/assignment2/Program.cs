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
            int smallestNumber = 149;
            int numberOfOccurences = 0;
            Random random = new Random();

            // creates 20 random numbers between 0 and 149 and display them and fill in an array with the random numbers
            int[] element = new int[20];
            for (int i = 0; i < element.Length; i++)
            {
                int randomNumber = random.Next(0, 150);
                Console.WriteLine("Element {0} = {1}", number, randomNumber);
                number++;
                element[i] = randomNumber;

                if (element[i] < smallestNumber)
                {
                    smallestNumber = element[i];
                }
            }

            // Count the number of occurences
            for (int i = 0; i < element.Length; i++)
            {
                if (element[i] == smallestNumber)
                {
                    numberOfOccurences++;
                }
            }

            // Display the smallest number and the number of occurences
            Console.WriteLine("\nsmallest number = {0}", smallestNumber);
            Console.WriteLine("number of occurence = {0}", numberOfOccurences);

            Console.ReadKey();
        }
    }
}
