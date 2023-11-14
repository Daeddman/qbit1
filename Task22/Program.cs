using System;

namespace task22
{
    class Task22
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());
            if (N >= 0 && N <= Math.Pow(10,9))
            {
                int hours = (N / 3600) % 24;
                int minutes = (N / 60) % 60;
                int seconds = N % 60;

                Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
            }

        }
    }
}