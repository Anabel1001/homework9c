﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число M: ");
Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {SumNum(m, n)}");

int SumNum(int m, int n)
{
    if (m == n)
        return n;
    return n + SumNum(m, n - 1);
}