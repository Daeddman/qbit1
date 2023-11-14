using System;

namespace task27
{
    class Task27
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            if (y >= 0 && y <= 1000 && n >= 0 && n <= 1000)
            {
                int result = (int)Math.Ceiling((y / (n + (n / 3.0))));
                Console.WriteLine($"{result}");

            }
        }
    }
}