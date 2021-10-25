using System;

namespace Assingment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your full name is " + firstName + " " + lastName);

            Console.WriteLine("Your full name is {0} {1}", firstName, lastName);

            Console.WriteLine($"Your full name is {firstName} {lastName}");

            Console.ReadKey();

        }
    }
}
