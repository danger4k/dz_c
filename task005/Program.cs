﻿/*
5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"

*/

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Целые числа от {-number} до {number}: ");
for (int i = -number; i < number + 1; i++)
{
    System.Console.Write(i + " ");
    if (i < number)
    {
        System.Console.Write(", ");
    }
}