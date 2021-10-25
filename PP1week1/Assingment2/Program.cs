using System;

namespace Assingment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:");
            String input = Console.ReadLine();

            int age = int.Parse(input);


            age++;

            string output = age.ToString();

            Console.WriteLine("Next year you would be " + age + " years old.");

            Console.ReadKey();
        }
    }
}
