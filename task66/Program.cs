/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int M = 1; // задайте значение M
        int N = 15; // задайте значение N

        int sum = 0;

        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}: {sum}");
    }
}
