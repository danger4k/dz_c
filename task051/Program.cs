/* 
51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

int[,] Get2dArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Pritn2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");

        }
        System.Console.WriteLine();
    }

}

int SumArr(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            if (i == j)
            {
                sum += arr[i, j];
            }
        }
    }
    return sum;
}


int[,] u2DArray = Get2dArray(4, 4);
Pritn2dArray(u2DArray);
System.Console.WriteLine();
int sum = SumArr(u2DArray);
System.Console.WriteLine($"Сумма чисел по главной диагонали {sum}");