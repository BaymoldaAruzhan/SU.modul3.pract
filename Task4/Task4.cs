//4
using System;

class Task4
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string input = Console.ReadLine();

        // Разбиваем введенную строку на слова с помощью пробелов
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Количество слов - это длина массива words
        int wordCount = words.Length;

        Console.WriteLine($"Количество слов в предложении: {wordCount}");
    }
}
