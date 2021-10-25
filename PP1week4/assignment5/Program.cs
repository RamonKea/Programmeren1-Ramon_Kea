using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1;

            while (year != 0)
            {
                Console.Write("Enter a year: ");
                year = int.Parse(Console.ReadLine());

                if (year > 0 && year != 0 && year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else if (year != 0 && year > 0)
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
                else if (year < 0)
                {
                    Console.WriteLine("Year must be positive!");
                }
            }
            Console.ReadKey();
        }
    }
}
