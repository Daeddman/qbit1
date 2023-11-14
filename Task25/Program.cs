using System;

namespace task25
{
    class Task25
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split();
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            if (a >= 0 && a <= 100 && b >= 0 && b <= 36)
            {
                double n = 37 * a + b;
                double m = Math.Floor(n/23.0);
                double h = n % 23.0;
                Console.WriteLine($"{m} {h}");
            }
        }
    }
}