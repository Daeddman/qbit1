using System;

namespace task5
{
    class Task5
    {
        static void Main()
        {
            double angleB = Convert.ToDouble(Console.ReadLine());
            if (angleB >= 0 && angleB <= 360.0)
            {
                double hours = angleB / 360.0 * 12;
                double minutes = (hours - Math.Floor(hours)) * 60.0;
                Console.Write($"{Math.Floor(hours)} {Math.Floor(minutes)}");
            }
            else
            {
                return;
            }
            
        }
    }
}