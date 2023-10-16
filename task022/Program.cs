/*
22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Write("Enter a number (N): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Number | Square");
        Console.WriteLine("----------------");
        
        for (int i = 1; i <= n; i++)
        {
            int square = i * i;
            Console.WriteLine($"{i,-6} | {square}");
        }
