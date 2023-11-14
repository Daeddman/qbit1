using System;

namespace task14
{
    class Task14
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split();
            double h = double.Parse(input[0]);
            double m = double.Parse(input[1]);
            double s = double.Parse(input[2]);
            if (h >= 1 && h <= 12 && m >= 0 && m < 60 && s >= 0 && s < 60)
            {
                //
                // double timeinseconds = ((h * 60) + (m * 60));
                // double degreesinsecond = 1/12.0;
                // double result = timeinseconds / degreesinsecond;
                double result = ((h * 30) + (m * 0.5) + (s * (1/120.0)));
                if (result >= 0 && result < 360)
                {
                    Console.WriteLine(result);
                }
            }

        }
    }
}