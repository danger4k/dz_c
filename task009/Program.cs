/*
9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int number = new Random().Next(10, 100);
System.Console.WriteLine(number);

int one = number / 10;
int two = number % 10;
System.Console.WriteLine(one);
System.Console.WriteLine(two);

if (one == two)
{
    System.Console.WriteLine($"Числа равны {one}");
}
else if (one > two) 
{System.Console.WriteLine($"Максимальное число {one}");}
else {System.Console.WriteLine($"Максимальное число {two}");}