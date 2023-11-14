using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int M = int.Parse(input[0]);
        int N = int.Parse(input[1]);

        int boxesForBalls = (int)Math.Ceiling((double)M / 3);
        int boxesForBaubles = (int)Math.Ceiling((double)N / 4);

        int totalBoxes = (int)Math.Ceiling((double)(boxesForBalls + boxesForBaubles));

        Console.WriteLine(totalBoxes);
    }
}