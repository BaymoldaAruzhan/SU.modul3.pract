//6
using System;
class Task6
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        int maxCount = 0;   // Максимальное количество подряд идущих символов
        int currentCount = 1;  // Текущее количество подряд идущих символов

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] == text[i - 1])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                currentCount = 1;  // Сбрасываем текущее количество
            }
        }

        // Проверяем последовательность в конце текста
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
        }

        if (maxCount > 1)
        {
            Console.WriteLine($"Наибольшее количество идущих подряд одинаковых символов: {maxCount}");
        }
        else
        {
            Console.WriteLine("В тексте нет идущих подряд одинаковых символов.");
        }
    }
}
