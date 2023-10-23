//9
using System;

class Task9
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int count = 0;

        foreach (string word in words)
        {
            if (word.Length >= 2 && word[0] == word[word.Length - 1])
            {
                count++;
            }
        }

        Console.WriteLine($"Количество слов, у которых первый и последний символы совпадают: {count}");
    }
}
