using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            double spongebob = LineValueForY(.75, 7, 0);

            Console.WriteLine($" y = (.75)7 + 0 ==> {spongebob.ToString("N2")}");

            int val2 = Factorial(5);
            Console.WriteLine($"5! = {val2.ToString("N2")}");

            Console.WriteLine("Pelase enter a number to calculate the factorial of >>");
            Console.WriteLine($" The value is {Factorial(Convert.ToInt32(Console.ReadLine()))}");
        }
        /// <summary>
        /// calculate the Y value of the line
        /// </summary>
        /// <param name="m">The slope of the line</param>
        /// <param name="x">The x-value of the line</param>
        /// <param name="b">The y-value of the line</param>
        /// <returns></returns>
        static double LineValueForY(double m, double x, double b)
        {
            double y = 0;

            y= m*x + b;

            return y;
        }

        // ctrl k, d to format/center


        /// <summary>
        /// Calculates the factorial of a value
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int Factorial (int number)
        {
            //5!
            // 5 * 4 * 3 * 2 * 1 = 120

            int value = 1;

            for (int i = number; i > 0; i--)
            {
                value *= i; 
            }

            return value;
        }

    }
}
