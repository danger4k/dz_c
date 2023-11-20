﻿/*
46. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
*/

int[,] Get2dArray(int row, int col)
{
int [,] array = new int[row, col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        array[i, j] = new Random().Next(0, 11);
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

int[,] user2DArray = Get2dArray(3, 4);

Pritn2dArray(user2DArray);