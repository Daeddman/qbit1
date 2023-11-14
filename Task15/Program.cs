using System;

namespace task15
{
    class Task15
    {
        static void Main()
        {
            double h = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (h >= 1 && h <= 100000 && a > 1 && a <= 100000 && b >= 1 && b < a)
            {
                double d = a - b;
                double result = Math.Ceiling(((h - a) / d) + 1);
                Console.WriteLine($"{result}");
            }

        }
    }
}