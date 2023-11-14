using System;

namespace task8
{
    class Task8
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            double a = double.Parse(data[0]);
            double b = double.Parse(data[1]);
            double c = double.Parse(data[2]);
            string[] input = Console.ReadLine().Trim().Split();
            double h = double.Parse(input[0]);
            double l = double.Parse(input[1]);
            if (a >= 1 && a <= 20 && b >= 1 && b <= 20 && c >= 2 && c <= 5 && h >= 300 &&
                h <= 1000 && l >= 4000 && l <= 20000)
            {
                double n = (h * l) / 1000000;
                double area = Math.Ceiling((0.935 * (2 * a * c + 2 * b * c + a * b)) / n);
                Console.WriteLine($"{area}");
            }


        }
    }
}