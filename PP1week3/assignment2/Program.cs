using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to choose from the numbers: 1, 2, 3 and 4
            Console.Write("Enter a number (1..4): ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            // Display text to the user, when a wrong number is given


            // switch the numbers from 1,2,3 and 4 to text 'clubs', 'diamonds', 'hearts' or 'spades' and display
            switch (number)
            {
                case 1:
                    Console.WriteLine("clubs");
                    break;
                case 2:
                    Console.WriteLine("diamonds");
                    break;
                case 3:
                    Console.WriteLine("hearts");
                    break;
                case 4:
                    Console.WriteLine("spades");
                    break;
                default:
                    Console.WriteLine("Incoreect number!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
