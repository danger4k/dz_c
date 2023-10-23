/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/


Console.WriteLine("Введите значения k1, b1, k2, b2 через пробел:");
string input = Console.ReadLine();
string[] values = input.Split(' ');

double k1 = double.Parse(values[0]);
double b1 = double.Parse(values[1]);
double k2 = double.Parse(values[2]);
double b2 = double.Parse(values[3]);

void Line(double k1, double k2, double b1, double b2)
{


    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
}

Line(k1, k2, b1, b2);