/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int Sumnum (int arg1)
{
int sum = 0;


while (arg1 > 0)
{
    sum += arg1 % 10;
    arg1 = arg1 / 10;
}
return sum;
}
int sumall = Sumnum (number);

System.Console.WriteLine(sumall);