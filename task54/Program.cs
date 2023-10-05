/*Задача 54: Задайте двумерный массив. Напишите программу на языке C#, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Упорядочиваем каждую строку по убыванию
        for (int i = 0; i < rows; i++)
        {
            // Используем сортировку вставками для текущей строки
            for (int j = 1; j < cols; j++)
            {
                int key = array[i, j];
                int k = j - 1;

                while (k >= 0 && array[i, k] < key)
                {
                    array[i, k + 1] = array[i, k];
                    k--;
                }

                array[i, k + 1] = key;
            }
        }

        // Выводим отсортированный двумерный массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
