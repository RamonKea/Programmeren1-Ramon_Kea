using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            Console.Write("Enter target number: ");
            string input = Console.ReadLine();
            int targetNumber = int.Parse(input);

            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            { 
                if (number == targetNumber)
                {
                    counter++;
                }

                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Count of numbers equal to target number: {0}", counter);
        }
    }
}
