using System;

namespace task29
{
    class Task29
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            double n = double.Parse(input[0]);
            double m = double.Parse(input[1]);
            if (m >= 1 && m <= Math.Pow(10, 9) && n >= 1 && n <= Math.Pow(10,9))
            {
                double maxRabbitsInOneCell = Math.Ceiling((m / n));

                Console.WriteLine(maxRabbitsInOneCell);
            }
        }
    }
}