using System;

namespace task6
{

    class Task6
    {

        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);
            if (a > 0 && a < 10000.0 && c > 0 && c < 10000.0 && b > 0 &&
                b < 10000.0 && (a + c > b) && (a + b > c) && (b + c > a))
            {
                double medianA = 0.5 * Math.Sqrt(2 * b * b + 2 * c * c - a * a);
                double medianB = 0.5 * Math.Sqrt((2 * (a * a)) + (2 * (c * c)) - (b * b));
                double medianC = 0.5 * Math.Sqrt(2 * a * a + 2 * b * b - c * c);

                Console.WriteLine($"{medianA}\n{medianB}\n{medianC}");


            }
            else
            {
                return;
            }
        }
    }
}