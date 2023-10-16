/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
System.Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

double Pow (int arg1, int arg2)
{
    double ow = 0;
    ow = Math.Pow(arg1, arg2);
    return ow;
}

double result = Pow(a,b);
System.Console.WriteLine(result);