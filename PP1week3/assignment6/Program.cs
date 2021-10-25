using System;

namespace assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the student to put in a score
            Console.Write("Enter score: ");
            string input = Console.ReadLine();
            int score = int.Parse(input);

            Console.WriteLine();

            // Convert the score from numbers to a grade and display the grade
            string grade = "";
            if (score >= 90 && score <= 100)
            {
                grade = "A";
                Console.WriteLine("grade: {0}", grade);
            }
            else if (score >= 80 && score <= 89)
            {
                grade = "B";
                Console.WriteLine("grade: {0}", grade);
            }
            else if (score >= 70 && score <= 79)
            {
                grade = "C";
                Console.WriteLine("grade: {0}", grade);
            }
            else if (score >= 60 && score <= 69)
            {
                grade = "D";
                Console.WriteLine("grade: {0}", grade);
            }
            else
            {
                grade = "F";
                Console.WriteLine("grade: {0}", grade);
            }

            // State whether or not the student has passed the subject
            if (score >= 70)
            {
                Console.WriteLine("course passed");
            }
            else
            {
                Console.WriteLine("course not passed");
            }

            Console.ReadKey();
        }
    }
}
