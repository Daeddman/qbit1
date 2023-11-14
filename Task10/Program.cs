using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        double v1 = double.Parse(input[0]);
        double v2 = double.Parse(input[1]);
        double v3 = double.Parse(input[2]);
        double v4 = double.Parse(input[3]);

        double averageSpeedAB = (v1 + v2) / 2;

        double averageSpeedBA = (2 * v3 * v4) / (v3 + v4);

        Console.WriteLine($"{averageSpeedAB:F3}");
        Console.WriteLine($"{averageSpeedBA:F3}");
    }
}