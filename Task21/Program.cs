using System;

namespace task25
{
    class Task25
    {
        static void Main()
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();

            int h1 = int.Parse(input1[0]);
            int m1 = int.Parse(input1[1]);
            int s1 = int.Parse(input1[2]);

            int h2 = int.Parse(input2[0]);
            int m2 = int.Parse(input2[1]);
            int s2 = int.Parse(input2[2]);
            int totalSeconds1 = h1 * 3600 + m1 * 60 + s1;
            int totalSeconds2 = h2 * 3600 + m2 * 60 + s2;
            int timeDifference = (totalSeconds2 - totalSeconds1);
            if (timeDifference < 0)
            {
                timeDifference = timeDifference * (-1);
                int hours = timeDifference / 3600;
                int minutes = (timeDifference % 3600) / 60;
                int seconds = timeDifference % 60;
                if (hours < 0)
                    hours += 24;
                if (minutes < 0)
                    minutes += 60;
                if (seconds < 0)
                    seconds += 60;
                Console.WriteLine($"{hours} {minutes} {seconds}");
            }
            else
            {


                int hours = timeDifference / 3600;
                int minutes = (timeDifference % 3600) / 60;
                int seconds = timeDifference % 60;
                if (hours < 0)
                    hours += 24;
                if (minutes < 0)
                    minutes += 60;
                if (seconds < 0)
                    seconds += 60;
                Console.WriteLine($"{hours} {minutes} {seconds}");
            }

        }
    }
}