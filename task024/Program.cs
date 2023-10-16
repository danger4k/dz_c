/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum1 = Num(a);
Console.WriteLine(sum1);

int Num(int a)
{
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum = sum + i;
    }

    return sum;
}
