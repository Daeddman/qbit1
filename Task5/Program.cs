using System;

namespace task5
{

    class Task5
    {

        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);
            if (a > 0 && a < 10000.0 && c > 0 && c < 10000.0 && b > 0 &&
                b < 10000.0 & (a + c > b) & (a + b > c) & (b + c > a))
            {
                double p = (a + b + c) / 2.0;
                double bisectorA = (2 * Math.Sqrt(b*c*p*(p-a))) / (b+c);
                double bisectorB = (2 * Math.Sqrt(a*c*p*(p-b))) / (a+c);
                double bisectorC = (2 * Math.Sqrt(a*b*p*(p-c))) / (a+b);

                Console.WriteLine($"{bisectorA}\n{bisectorB}\n{bisectorC}");


            }
            else
            {
                return;
            }
        }
    }
}