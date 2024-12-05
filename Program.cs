using System;

class Program
{
    static void Main(string[] args)
    {
        // Масив назв місяців
        string[] months = { "Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень",
                            "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень" };

        // Масив середніх температур
        double[] temperatures = { -3.5, -2.1, 1.0, 8.3, 14.8, 18.5, 21.4, 20.8, 15.2, 9.1, 2.5, -1.2 };

        // Делегат для обробки місяців
        Action<int> displayMonthInfo = null;

        // Реалізуємо три методи для обробки конкретних місяців
        displayMonthInfo += DisplayJanuaryInfo;
        displayMonthInfo += DisplayMayInfo;
        displayMonthInfo += DisplayOctoberInfo;

        Console.WriteLine("Введіть номер місяця (1-12):");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int monthNumber) && monthNumber >= 1 && monthNumber <= 12)
        {
            // Викликаємо методи для вказаного місяця
            Console.WriteLine($"Місяць: {months[monthNumber - 1]}");
            Console.WriteLine($"Середня температура: {temperatures[monthNumber - 1]} °C");

            // Виклик групового делегата
            displayMonthInfo?.Invoke(monthNumber);
        }
        else
        {
            Console.WriteLine("Невірний номер місяця. Будь ласка, введіть число від 1 до 12.");
        }
    }

    // Метод для січня
    static void DisplayJanuaryInfo(int month)
    {
        if (month == 1)
        {
            Console.WriteLine("Січень: Зазвичай холодний місяць зі снігом.");
        }
    }

    // Метод для травня
    static void DisplayMayInfo(int month)
    {
        if (month == 5)
        {
            Console.WriteLine("Травень: Час весни та квітучих садів.");
        }
    }

    // Метод для жовтня
    static void DisplayOctoberInfo(int month)
    {
        if (month == 10)
        {
            Console.WriteLine("Жовтень: Осінній місяць з прохолодною погодою.");
        }
    }
}
