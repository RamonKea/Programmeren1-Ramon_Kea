using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            // ask the user to enter two numbers
            Console.Write("Enter first number: ");
            string firstInput = Console.ReadLine();
            int firstNumber = int.Parse(firstInput);

            Console.Write("Enter second number: ");
            string secondInput = Console.ReadLine();
            int secondNumber = int.Parse(secondInput);

            // calculate if the numbers are multiples or not and display it
            if (firstNumber % secondNumber == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }
            else
            {
                if (secondNumber % firstNumber == 0)
                {
                    Console.WriteLine("Number 2 is multiple of number 1");
                }
                else
                {
                    Console.WriteLine("Numbers are no multiples");
                }
            }

        }
    }
}
