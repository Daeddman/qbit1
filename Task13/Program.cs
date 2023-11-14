using System;

namespace task13
{
    class Task13
    {
        static void Main()
        {
            double n = Convert.ToDouble(Console.ReadLine());
            if (n >= 1 && n <= 1000)
            {
                double water = 249.5 * n / 0.05;
                double molecul = 249.5 * n / (3 * Math.Pow(10, -23));
                Console.Write($"{water} {molecul:g4}");
            }
        }
    }
}