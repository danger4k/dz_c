/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

Console.Write("Введите числа через запятую: ");
string input = Console.ReadLine();

int count = PositiveCount(input);
Console.WriteLine($"Количество чисел, больше 0: {count}");

int PositiveCount(string[])
{
    input = input.Replace(" ", "");

    string[] numbers = input.Split(',');
    int positiveNumbersCount = 0;

    foreach (string number in numbers)
    {
        int num = Convert.ToInt32(number);

        if (num > 0)
        {
            positiveNumbersCount++;
        }
    }
    return positiveNumbersCount;
}


