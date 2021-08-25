using System;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please enter your score for Exam {i + 1}");
                sum += Convert.ToDouble(Console.ReadLine());
            }
            double average = sum / 300;
            // using the "P2" automatically multiples it by 100; 300 is 3 * 100 to divide it by both 
            Console.WriteLine($"Your average exam grade is {average.ToString("P2")}");
        }
    }
}
