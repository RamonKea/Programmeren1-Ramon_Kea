using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user to enter three numbers
            Console.Write("Enter first number: ");
            string firstInput = Console.ReadLine();
            int firstNumber = int.Parse(firstInput);

            Console.Write("Enter second number: ");
            string secondInput = Console.ReadLine();
            int secondNumber = int.Parse(secondInput);

            Console.Write("Enter third number: ");
            string thirdInput = Console.ReadLine();
            int thirdNumber = int.Parse(thirdInput);

            // Calculate if the third number is the smallest of the three
            if (firstNumber > thirdNumber && secondNumber > thirdNumber)
            {
                // Display to the user that the third number is the smallest of the three
                Console.WriteLine("The third number is the smallest of the three");
            }
            else
            {
                // Display to the user that the third number is not the smallest of the three
                Console.WriteLine("The third number is not the smallest of the three");
            }


            Console.ReadKey();
        }
    }
}
