using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();

            bool shouldIContinue = true;

            while (shouldIContinue)
            {
                Console.WriteLine("Please enter your exam grade.");
                double grade = Convert.ToDouble(Console.ReadLine());

                examGrades.Add(grade);

                Console.WriteLine("Do you have another exam grade to enter?");

                if (Console.ReadLine().ToLower() != "yes")
                {
                    shouldIContinue = false;
                    break;
                }
            }

            double sum = 0;

            foreach (double grades in examGrades)
            {
                sum += grades;
            }

            Console.WriteLine($"Your exam average exam greade is {sum/(examGrades.Count).ToString("P2")}");
        }
    }
}
