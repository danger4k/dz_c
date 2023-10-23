/*
32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] arr = {1, -1, 10, 15, -20};

Print(arr);

System.Console.WriteLine();

ReverseElementsValue(arr);

Print(arr);


void ReverseElementsValue(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

void Print(int [] arr)
{
    foreach (int i in arr) System.Console.Write(i + " ");
}