/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

using System;

class Program
{
    static void Main()
    {
        // Создаем массив
        int[] array = new int[4];

        // Заполняем массив случайными числами
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 100);
        }

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Вычисляем сумму элементов на нечетных позициях
        int sumOddPositions = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sumOddPositions += array[i];
        }

        // Выводим результат на экран
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sumOddPositions);
    }
}
