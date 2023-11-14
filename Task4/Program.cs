using System;

namespace task4
{
    class Task4
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            double x1 = double.Parse(input[0]);
            double y1 = double.Parse(input[1]);
            double x2 = double.Parse(input[2]);
            double y2 = double.Parse(input[3]);
            if (x1 <= 10000.0 && y1 <= 10000.0 && x2 <= 10000.0 && y2 <= 10000.0 &&
                x1 >= -10000.0 && y1 >= -10000.0 && x2 >= -10000.0 && y2 >= -10000.0)
            {
                double r = Math.Pow((Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2)), 0.5);
                Console.WriteLine($"{r}");
            }

        }
    }
}