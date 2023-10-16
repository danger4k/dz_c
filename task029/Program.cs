/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

System.Console.WriteLine("Введите колличество элементов:");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите минимальное значение:");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите максимальное значение:");
int max = Convert.ToInt32(Console.ReadLine());

int[] GetRnd(int size, int min, int max)
{
    int[] array = new int[size];// = {1,0,1,0,0,0,1,1}
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
int[] userArray = GetRnd(size,min,max);
PrintArray(userArray);