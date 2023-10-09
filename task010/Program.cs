/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int num = new Random().Next(100, 1000);

System.Console.WriteLine("Сегенерировано трехзначное число: " + num);

int temp = num / 10;

num = temp % 10;

System.Console.WriteLine(num);

