using System;

namespace task28
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split();
            int N = int.Parse(input[0]);
            long P = long.Parse(input[1]);
            if (N >= Math.Pow(-10, 9) && N <= Math.Pow(10, 9) && P >= 1 && N <= Math.Pow(10, 9))
            {
                long M;
                if (N >= 0)
                {
                    M = (N + P - 1) / P * P;
                }
                else
                {
                    M = (N / P) * P;
                }
                Console.WriteLine($"{M}");
            }
        }
    }
}
