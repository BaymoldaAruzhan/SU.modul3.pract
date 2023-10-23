//2
using System;
using System.Linq;

class Task2
{
    static void Main()
    {
        // Задание массивов M и N
        int[] M = { 1, 2, 3, 4, 5 };
        int[] N = { 3, 4, 5, 6, 7 };

        // Находим общие элементы без повторений
        int[] commonElements = M.Intersect(N).ToArray();

        // Выводим общие элементы в третий массив
        Console.WriteLine("Общие элементы без повторений:");
        foreach (int element in commonElements)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }
}
