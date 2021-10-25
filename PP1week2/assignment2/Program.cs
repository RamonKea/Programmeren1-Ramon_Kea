using System;
using System.Globalization;
using System.Threading;

namespace assingment2
{
    class Program
    {
        const double three = 3;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // Read the numbers that the user puts in
            Console.Write("Enter 1st number: ");
            string firstinput = Console.ReadLine();
            double firstnumber = double.Parse(firstinput);

            Console.Write("Enter 2nd number: ");
            string secondinput = Console.ReadLine();
            double secondnumber = double.Parse(secondinput);

            Console.Write("Enter 3rd number: ");
            string thirdinput = Console.ReadLine();
            double thirdnumber = double.Parse(thirdinput);

            // calculate the average of the numbers
            double average = (firstnumber + secondnumber + thirdnumber) / three;
            Console.Write("The average is: {0}", average);

            Console.ReadKey();
        }
    }
}
