/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int num = new Random().Next();

// int num = 10211;
int number = 0;

System.Console.WriteLine("Сегенерировано трехзначное число: " + num);
if (num < 0) { num = num * -1; };
if (num > 99)
{
    for (int i = num; i > 99; i /= 10)
    {
        number = i;
    }
    System.Console.WriteLine($"Третья цифра {number % 10}");
}
else System.Console.WriteLine("Нет третьей цифры");