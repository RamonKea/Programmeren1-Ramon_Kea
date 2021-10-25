using System;
using System.Globalization;
using System.Threading;


namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            double sumOfGrades = 0;
            double average = 0;
            string studentWithHighestGrade = "";
            double highestGrade = 0;

            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();

            // Ask user for the number of students
            Console.Write("Enter number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Make an array with the names
            string[] names = new string[numberOfStudents];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter name of student {0}: ", i + 1);
                names[i] = Console.ReadLine();
            }
            Console.WriteLine();

            // Make an array with the grades from the students
            double[] grades = new double[numberOfStudents];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter grade of {0}: ", names[i]);
                grades[i] = double.Parse(Console.ReadLine());
                sumOfGrades += grades[i];
            }
            Console.WriteLine();

            // Calculate and Display the Average grade
            average = sumOfGrades / numberOfStudents;
            Console.WriteLine("Average grade: {0:F1}", average);

            // Calculate who has the maximum grade
            for (int i = 0; i < names.Length; i++)
            {
                if (grades[i] > highestGrade)
                {
                    highestGrade = grades[i];
                    studentWithHighestGrade = names[i];
                }
            }

            //Display who has the Maximum grade
            Console.WriteLine($"Student {studentWithHighestGrade} has maximum grade: {highestGrade}\n");

            // Display the values of the arrays
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Grade for student {0} (course {1}): {2}", names[i], courseName, grades[i]);
            }

            Console.ReadKey();
        }
    }
}
