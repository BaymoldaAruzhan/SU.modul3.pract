//3
using System;

class Task3
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        // Удаляем пробелы и приводим к нижнему регистру для упрощения сравнения
        string cleanInput = input.Replace(" ", "").ToLower();

        bool isPalindrome = true;

        for (int i = 0, j = cleanInput.Length - 1; i < j; i++, j--)
        {
            if (cleanInput[i] != cleanInput[j])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Это палиндром.");
        }
        else
        {
            Console.WriteLine("Это не палиндром.");
        }
    }
}
