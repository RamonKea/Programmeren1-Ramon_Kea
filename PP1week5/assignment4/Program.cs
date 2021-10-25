using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = 1;
            int counter = 0;
            int searchValue = 0;
            int searchValueOccurences = 0;
            int i = 0;

            // Ask the user to enter a number until the number 0 and count the amount of numbers that where put in
            int[] numbers = new int[20];
            while (numberInput != 0)
            {
                Console.Write("Enter a number (0=stop): ");
                numberInput = int.Parse(Console.ReadLine());

                if (counter < 20 || numberInput != 0)
                {
                    counter++;
                    numbers[i] = numberInput;
                    i++;
                }               
            }

            // Ask the user for a search value
            Console.Write("\nEnter a searchvalue: ");
            searchValue = int.Parse(Console.ReadLine());

            // Count the number of times the search value is occurd
            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchValue)
                {
                    searchValueOccurences++;
                }
            }

            // Display how many times the search value is occurd
            Console.Write("\nNumber of occurences of searchvalue ({0}) is: {1}", searchValue, searchValueOccurences);
            
            Console.ReadKey();
        }
    }
}
