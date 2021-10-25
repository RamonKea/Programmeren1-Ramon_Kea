using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for user input until the user puts in 0
            int number = 1;

            while (number != 0)
            {
                Console.Write("Enter number (0 is stop value): ");
                number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }
                else if (number < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }
                else if (numberIsPrime(number))
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }

            // Display the end of program when 0 is entered as input
            Console.WriteLine("end of program");
            Console.ReadKey();
        }

        // Create method that accepts an int parameter and returns a boolaen value
        static bool numberIsPrime(int number)
        {
            // Determine if the positive numbers are prime numbers
            if (number <= 1) return false;
            else if (number == 2) return true;
            else if (number % 2 == 0) return false;

            // Determains the range of the loop by rounding off the number with Math.Floor and square rooting that number so big numbers can be divided into smaller numbers, so that the loop can run less times.
            var range = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= range; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
