using System;

namespace PaintCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            
            double A = double.Parse(input[0]);
            double B = double.Parse(input[1]);
            double C = double.Parse(input[2]);
            double X = double.Parse(input[3]);

            double surfaceArea = 200 * (A * B + B * C + A * C);

            double paintNeeded = surfaceArea * X;

            double litersNeeded = Math.Ceiling(paintNeeded / 1000.0);

            Console.WriteLine(litersNeeded);
        }
    }
}