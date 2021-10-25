using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1;

            // Ask the user to put in a year and stop if value is 0
            while (year != 0)
            {
                Console.Write("Enter a year: ");
                year = int.Parse(Console.ReadLine());

                // Determine if year is a leap year or not
                if (year == 0)
                {
                    break;
                }
                else if (year < 0)
                {
                    Console.WriteLine("Negative year entered...");
                }
                else if (yearIsLeap(year))
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
            }
            
            // Display the end of program when 0 is entered as input
            Console.WriteLine("end of program");
            Console.ReadKey();
        }

        // Create method that accepts an int parameter and returns a boolaen value
        static bool yearIsLeap(int year)
        {
            // Determine if the year is a leap year or not
            if (year > 0 && year != 0 && year % 400 == 0 || year % 4 == 0 && year % 100 != 0) return true;
            else if (year <= 1 || year == 0 || year != 0 && year > 0) return false;
            return true;
        }
    }
}


