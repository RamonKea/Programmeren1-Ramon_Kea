using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a text
            Console.Write("Enter a text> ");
            string textLine = Console.ReadLine();

            SearchText(textLine, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons);
            

            //Display the amount of times that the characters: '.' ',' and ';' occur in the string
            Console.WriteLine("result: {0} full stops, {1} commas, {2} semicolons", nrOfFullStops, nrOfCommas, nrOfSemiColons);

            Console.ReadKey();
        }

        // Count the number of times that the characters: '.' ',' and ';' occur in the string, in a seperate method with the name 'SearchText', with a string as input and 3 out parameters: nrOfFullStops, nrOfCommas, nrOfSemiColons. (no return value)
        static void SearchText(string textLine, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons)
        {
            nrOfFullStops = textLine.Split('.').Length - 1;
            nrOfCommas = textLine.Split(',').Length - 1;
            nrOfSemiColons = textLine.Split(';').Length - 1;
        }
    }
}
