using System;

namespace task3
{
    class Task3
    {
        static void Main()
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double s = Math.PI * Math.Pow(r, 2);
            double l = 2 * Math.PI * r;
            Console.WriteLine($"{s}");
            Console.WriteLine($"{l}");
        }
    }
}