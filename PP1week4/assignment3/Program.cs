using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int sumOfSelectedNumbers = 0;
            int numberInput = 1;

            while (numberInput != 0)
            {
                Console.Write("Enter a number: ");
                numberInput = int.Parse(Console.ReadLine());
                counter++;

                if (counter % 5 == 0)
                {
                    sumOfSelectedNumbers += numberInput;
                }
            }

            Console.WriteLine("Sum of 5th, 10th, 15th, ... number is: {0}", sumOfSelectedNumbers);
        }
    }
}
