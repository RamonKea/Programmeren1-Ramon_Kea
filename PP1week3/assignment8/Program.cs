using System;

namespace assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user to put in the amount of working hours, how many years old and how many failures the machine has A year
            Console.Write("Enter number of working hours: ");
            string inputWorkingHours = Console.ReadLine();
            int workingHours = int.Parse(inputWorkingHours);

            Console.Write("Enter number of years: ");
            string inputAmountOfYears = Console.ReadLine();
            int amountOfYears = int.Parse(inputAmountOfYears);

            Console.Write("Enter number of failures: ");
            string inputAmountOfFailuresAYear = Console.ReadLine();
            int amountOfFailuresAYear = int.Parse(inputAmountOfFailuresAYear);

            Console.WriteLine();

            // Check whether or not the machine needs to be replaced and display it
            if (workingHours > 10000 | amountOfYears >= 7 | amountOfFailuresAYear > 25)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }
            else
            {
                Console.WriteLine("Machine does not need to be replaced.");
            }

            Console.ReadKey();
        }
    }
}
