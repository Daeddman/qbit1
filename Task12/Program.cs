using System;

namespace task12
{
    class Task12
    {
        static void Main()
        {

            long a = Convert.ToInt64(Console.ReadLine());
            long b = Convert.ToInt64(Console.ReadLine());
            if (a >= 1 && a <= 1000000000.0 && b >= 1 && b <= 1000000000.0)
            {
                long result = (a + b);
                Console.WriteLine($"{a}".PadLeft(10));
                Console.WriteLine($"{b}".PadLeft(10));
                Console.WriteLine("----------");
                Console.WriteLine($"{result}".PadLeft(10));
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}