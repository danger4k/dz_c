/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum1 = Count(a);
Console.WriteLine(sum1);

int Count(int a)
{
    int result = 0;

    for (int i = a; i > 0; i /= 10)
    {
        result += 1;
    }
    return result;
}