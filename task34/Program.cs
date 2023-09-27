/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

using System;

class Program
{
    static void Main()
    {
        // Создаем массив
        int[] array = new int[4];

        // Заполняем массив случайными трехзначными числами
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Счетчик четных чисел
        int count = 0;

        // Проверяем каждое число в массиве
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }

        // Выводим количество четных чисел
        Console.WriteLine("Количество четных чисел: " + count);
    }
}
