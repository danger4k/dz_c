/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum1 = Factorial(a);
Console.WriteLine(sum1);

int Factorial(int a)
{
    int sum = 1;
    for (int i = sum; i <= a; i++)
    {
        sum = sum * i;
    }

    return sum;
}
