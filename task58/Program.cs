/* Задача 58: Задайте две матрицы. Напишите программу на C#, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

using System;

class Program
{
    static void Main()
    {
        // Создаем две матрицы
        int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
        int[,] matrix2 = { { 3, 4 }, { 3, 3 } };

        // Проверяем, возможно ли выполнить умножение матриц
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            Console.WriteLine("Умножение матриц невозможно.");
            return;
        }

        // Создаем результирующую матрицу
        int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        // Выполняем умножение матриц
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        // Выводим результирующую матрицу на экран
        Console.WriteLine("Результирующая матрица:");
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
