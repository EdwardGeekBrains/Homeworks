/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        int smallestRowSum = int.MaxValue;
        int smallestRowIndex = -1;

        for (int row = 0; row < array.GetLength(0); row++)
        {
            int rowSum = 0;

            for (int col = 0; col < array.GetLength(1); col++)
            {
                rowSum += array[row, col];
            }

            if (rowSum < smallestRowSum)
            {
                smallestRowSum = rowSum;
                smallestRowIndex = row;
            }
        }

        Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (smallestRowIndex + 1));
    }
}
