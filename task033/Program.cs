/*
33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

System.Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

int[] arr = { 1, -1, 10, 15, -20 };

bool IsExist(int[] array, int arg)
{
    foreach (int element in array)
    {
        if (element == arg) return true;
        
    }
    return false;
}

System.Console.WriteLine(IsExist(arr, a));