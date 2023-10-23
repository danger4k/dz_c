/*
45. Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.
*/

int[] array = { 0, 5, 6, 3, 12, -5 };

int[] NewArr(int[] array)
{
    int len = array.Length;
    int[] newArray = new int[len];

    for (int i = 0; i < len; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}
System.Console.Write("Исходный массив");
PrintArray(array);

System.Console.WriteLine();

System.Console.Write("Новый массив   ");
PrintArray(NewArr(array));