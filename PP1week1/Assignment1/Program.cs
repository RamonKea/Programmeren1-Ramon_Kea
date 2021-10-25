using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");

            // variable 'name' is declared here
            string name;

            // read the name of te user and save it in  variable 'name'
            name = Console.ReadLine();

            Console.WriteLine("Enter your age:");

            // read the age of the user and save it in variable 'age'
            // (variable 'age' is declared here and immediatly give a value)
            string age = Console.ReadLine();

            // display name and age
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);

            // Wait for the user to enter a key 
            Console.ReadKey();
        }
    }
}
