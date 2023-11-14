using System;
namespace task18
{
    class Task18
    {
        static void Main()
        {
            string[] input1 = Console.ReadLine().Trim().Split();
            int a = int.Parse(input1[0]);
            int b = int.Parse(input1[1]);

            string[] input2 = Console.ReadLine().Trim().Split();
            int c = int.Parse(input2[0]);
            int d = int.Parse(input2[1]);
            
            int priceInKopecks = a * 100 + b;
            int moneyInKopecks = c * 100 + d;
            
            int numberOfPens = moneyInKopecks / priceInKopecks;
            int remainingKopecks = moneyInKopecks % priceInKopecks;
            
            Console.WriteLine(numberOfPens);
            Console.WriteLine(remainingKopecks / 100 + " " + remainingKopecks % 100);
        }
    }
}