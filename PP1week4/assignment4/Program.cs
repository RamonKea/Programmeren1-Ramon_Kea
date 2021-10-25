using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 1;
            int numberTwo = 1;
            int numberThree = 0;
            int number = 20;
            int i = 0;

            Console.Write($"{numberOne}, {numberTwo}");

            for (i = 2; i < number; ++i)
            {
                numberThree = numberOne + numberTwo;
                Console.Write(", {0}", numberThree);
                numberOne = numberTwo;
                numberTwo = numberThree;
            }

            Console.ReadKey();
        }
    }
}
