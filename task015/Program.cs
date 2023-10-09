/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Введите номер дня недели:");
int number1 = Convert.ToInt32(Console.ReadLine());

string[] day = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
if (number1 > 7 || number1 < 1)
{System.Console.WriteLine("Введи число от 1 до 7, рукожоп");}
else{
if(number1 == 6 || number1 == 7)
{
System.Console.WriteLine("Иди бухать, сегодня выходной");
}
else {System.Console.WriteLine("Иди работать");}
}