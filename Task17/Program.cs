using System;

namespace task17
{
    class Task17
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int n = int.Parse(input[2]);
            
            int totalTugriks = (n * a) + ((n * b) / 100);
            int totalShmugriks = (n * b) % 100;

            Console.WriteLine($"{totalTugriks} {totalShmugriks}");
        }
    }
}