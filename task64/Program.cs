/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(GetNaturalNumbers(N));
    }
    
    static string GetNaturalNumbers(int num)
    {
        if (num <= 0)
        {
            return ""; // базовый случай: если число меньше или равно 0, возвращаем пустую строку
        }
        else
        {
            return num.ToString() + ", " + GetNaturalNumbers(num - 1); // рекурсивный случай: выводим текущее число и вызываем функцию с уменьшенным числом на 1
        }
    }
}
