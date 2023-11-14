using System;

namespace task11
{
    class Task11
    {
        static void Main()
        {
            string command = Console.ReadLine();
            string team1 = command.Length <= 12 ? command : command.Substring(0, 12);
            int score1 = int.Parse(Console.ReadLine());

            string command2 = Console.ReadLine();
            string team2 = command2.Length <= 12 ? command2 : command2.Substring(0, 12);
            int score2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{team1,+12} : {team2}");
            Console.WriteLine($"{score1,+12} : {score2}");
        }
    }
}