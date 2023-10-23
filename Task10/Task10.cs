using System;
class Task10
{
    static void Main()
    {
        Console.Write("Введите строку с малыми русскими буквами: ");
        string input = Console.ReadLine();

        string uppercaseInput = ConvertToUppercase(input);

        Console.WriteLine("Преобразованная строка: " + uppercaseInput);
    }
    static string ConvertToUppercase(string input)
    {
        // Создаем пустую строку, в которую будем добавлять большие буквы
        string result = "";

        // Проходим по каждому символу в исходной строке
        foreach (char character in input)
        {
            // Проверяем, является ли символ малой русской буквой
            if (IsLowerCyrillic(character))
            {
                // Преобразуем малую букву в большую и добавляем к результату
                char uppercaseChar = char.ToUpper(character);
                result += uppercaseChar;
            }
            else
            {
                // Если символ не является малой русской буквой, добавляем его без изменений
                result += character;
            }
        }

        return result;
    }

    // Функция для проверки, является ли символ малой русской буквой
    static bool IsLowerCyrillic(char character)
    {
        return character >= 'а' && character <= 'я';
    }
}
