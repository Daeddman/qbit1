using System;

namespace task19
{
    class Task19
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split();

            int H = int.Parse(input[0]);
            int M = int.Parse(input[0]);
            int S = int.Parse(input[0]);

            
                if (H >= 0 && H <= 23 && M >= 0 && M <= 60 && S >= 0 && S <= 60)
                {


                    S++;
                    if (S == 60)
                    {
                        S = 0;
                        M++;
                    }

                    if (M == 60)
                    {
                        M = 0;
                        H++;
                    }

                    if (H == 24)
                    {
                        H = 0;
                    }

                    Console.WriteLine($"{H} {M} {S}");
                }

            


        }
    }
}