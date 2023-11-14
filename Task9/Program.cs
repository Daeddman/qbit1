using System;

namespace task9
{
    class Task9
    {
        static void Main()
        {

            string[] input = Console.ReadLine().Trim().Split();
            double p = double.Parse(input[0]);
            double x = double.Parse(input[1]);
            double y = double.Parse(input[2]);

            if (p >= 1 && p <= 1000 && x >= 1 && x <= 100 && y >= 1 && y <= 100)
            {
                double length = (p * x) / (2 * (x + y));
                double width = (p * y) / (2 * (x + y));
                double area = length * width;
                Console.WriteLine(area);
            }
            
        }
    }
}