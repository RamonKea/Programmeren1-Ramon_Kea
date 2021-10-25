using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of seconds: ");

            string input = Console.ReadLine();
            int totalseconds = int.Parse(input);

            // Calculate how many hours can be substracted from the number of seconds
            int hours = totalseconds / 3600;
            int remainingseconds = totalseconds % 3600;

            // Calculate how many minutes can be substracted from the number of seconds
            int minutes = remainingseconds / 60;
            int seconds = remainingseconds % 60;

            // Display the number of hours, minutes and seconds
            Console.WriteLine("{0:00}:{1:00}:{2:00}", hours, minutes, seconds );

            Console.ReadKey();
        }
    }
}
