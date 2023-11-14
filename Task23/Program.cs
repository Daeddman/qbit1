using System;

class Program
{
    static void Main()
    {
        // Зчитуємо число K зі стандартного потоку введення
        int K = int.Parse(Console.ReadLine());

        // Визначаємо, який день тижня був 1 січня (субота)
        int dayOfWeekOfJan1 = 6;

        // Визначаємо номер дня тижня для K-го дня року
        int dayOfWeek = (dayOfWeekOfJan1 + K - 1) % 7;

        // Перевіряємо, чи отриманий результат є нулем (неділя), і встановлюємо його в 7 (неділя)
        if (dayOfWeek == 0)
            dayOfWeek = 7;

        // Виводимо номер дня тижня для K-го дня року
        Console.WriteLine(dayOfWeek);
    }
}