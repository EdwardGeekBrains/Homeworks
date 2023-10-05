/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу на C#, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,,] array = new int[2, 2, 2];
        int number = 10;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array[i, j, k] = number++;
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
                }
            }
        }
    }
}
