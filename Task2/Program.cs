using System;

namespace task2
{
    class Task2
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);
            int d = int.Parse(data[3]);
            int e;
            if (a >= 1 && a <= 5 && b >= 1 && b <= 5 && c >= 1 && c <= 5 && d >= 1 && d <= 5)
            {
                e = 15 - (a + b + c + d);
                Console.WriteLine($"{e}");
            }
        }
        
    }
}