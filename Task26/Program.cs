using System;

namespace task26
{
    class Task26
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (l >= 1 && l <= 30 && k >= 1 && k <= 300)
            {
                double result = Math.Ceiling(l / (k / 10.0));
                Console.WriteLine(result);
            }
        }
    }
}