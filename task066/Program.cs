/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.



*/

Console.Clear();

Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

int sum = SumOfNumbers(m, n);
Console.WriteLine($"Сумма чисел в промежутке от {m} до {n}: {sum}");

int SumOfNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }

    return m + SumOfNumbers(m + 1, n);
}
