using System;

namespace assignment7
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask the user how much weight he/she is in kilograms
                Console.Write("Enter weight (kg): ");
            string inputWeight = Console.ReadLine();
            double weight = double.Parse(inputWeight);

            // Ask the user how tall he/she is in centimeters
            Console.Write("Enter length (cm): ");
            string inputLenghtInCentimeters = Console.ReadLine();
            double lenghtInCentimeters = double.Parse(inputLenghtInCentimeters);

            // Ask the user whether he/she is a male or a female
            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();

            Console.WriteLine();

            // Calculate the length in meters from centimeters
            double lengthInMeters = lenghtInCentimeters / 100;

            // Caculate the Body Mass Index (BMI) of the user and display it
            double bodyMassIndex = weight / (lengthInMeters * lengthInMeters);
            Console.WriteLine("bmi-value: {0:F1}", bodyMassIndex);

            // If he/she is a male, display the normal BMI-values for male and calculate the healthy weight range for a male
            if (gender == "male")
            {
                Console.WriteLine("normal bmi-values (min .. max): 20..25");
                double healthyWeightRangeForMaleMin = 20 * lengthInMeters * lengthInMeters;
                double healthyWeightRangeForMaleMax = 25 * lengthInMeters * lengthInMeters;
                Console.WriteLine("healthy weight range: {0:F1} .. {1:F1}", healthyWeightRangeForMaleMin, healthyWeightRangeForMaleMax);
            }

            // If he/she is a female, display the normal BMI-values for a female and calculate the healthy weight range for a female
            else
            {
                Console.WriteLine("normal bmi-values (min .. max): 19..24");
                double healthyWeightRangeForFemaleMin = 19 * lengthInMeters * lengthInMeters;
                double healthyWeightRangeForFemaleMax = 24 * lengthInMeters * lengthInMeters;
                Console.WriteLine("healthy weight range: {0:F1} .. {1:F1}", healthyWeightRangeForFemaleMin, healthyWeightRangeForFemaleMax);
            }

            Console.ReadKey();
        }
    }
}
