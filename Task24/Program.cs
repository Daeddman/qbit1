using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Trim().Split();
        int K = int.Parse(input[0]);
        int N = int.Parse(input[1]);

        int dayOfWeek = (K + N - 2) % 7 + 1;

        Console.WriteLine($"{dayOfWeek}");
    }
}