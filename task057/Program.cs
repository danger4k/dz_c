/*
57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/

int[,] GetRnd(int rows, int colom)
{
    int[,] array = new int[rows, colom];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[,] testArray = GetRnd(5, 5);

for (int i = 0; i < testArray.GetLength(0); i++)
{
    for (int j = 0; j < testArray.GetLength(1); j++)
    {
        Console.Write(testArray[i, j] + " ");
    }
    Console.WriteLine();
}


PrintElementsCount(testArray);



void PrintElementsCount(int[,] arr)
{
    List<int> list = new List<int>();

    
    foreach (int item in arr) 
    {
        if (!list.Contains(item))
        {         
            int count = 0;   
            foreach (int checkitem in arr) 
            {
                if (item == checkitem) count++;
            }

            System.Console.WriteLine(item + " встречается " + count + " раз");
        }
        list.Add(item);
    }
}