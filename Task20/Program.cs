using System;

namespace task20
{
    class Task20
    {
        static void Main()
        {
            string[]input1 = Console.ReadLine().Trim().Split();
            int h = int.Parse(input1[0]);
            int m = int.Parse(input1[1]);
            int s = int.Parse(input1[2]);
            string[] input2 = Console.ReadLine().Trim().Split();
            int h1 = int.Parse(input2[0]);
            int m1 = int.Parse(input2[1]);
            int s1 = int.Parse(input2[2]);
            
            int totalSeconds1 = h * 3600 + m * 60 + s;
            int totalSeconds2 = h1 * 3600 + m1 * 60 + s1;
            int totalSeconds = (totalSeconds1 + totalSeconds2) % (24 * 3600);

            int h2 = totalSeconds / 3600;
            int m2 = (totalSeconds % 3600) / 60;
            int s2 = totalSeconds % 60;
            Console.WriteLine($"{h2} {m2} {s2}");
        }
    }
}